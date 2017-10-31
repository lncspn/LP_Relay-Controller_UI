/************************************************************
* Copyright(C) 2017, Luis Navarro Carrero, Kevlin Sun, LattePanda
* FileName: ArduinoCustomFirmata.cs
* Author:   Luis Navarro Carrero
* Version:  V1.0
* Date:     2017
* Description: CustomArduino.Firmata is an open-source Firmata
  custom-reduced library provided by LattePanda and modified
  by Luis Navarro Carrero for only digitalWrite (low CPU Load),
  which is suitable for Windows apps developed in Visual Studio.
  This class allows you to control the Arduino board from Windows apps:
  writing to the digital pins
* This library is free software; you can redistribute it and/or
  modify it under the terms of the GNU Lesser General Public
  License as published by the Free Software Foundation; either
  version 2.1 of the License, or (at your option) any later version.
* Special thanks to Tim Farley, on whose Firmata.NET library
  this code is based.
* Special thanks to Kevlin Sun, on whose LattePanda.Firmata library
  this code is based.

*************************************************************/

using System;
using System.IO.Ports;
using System.Threading;
using System.Linq;

namespace LattePanda.CustomFirmata
{
    class Arduino
    {
        public const byte LOW = 0;
        public const byte HIGH = 1;
        public const byte OUTPUT = 1;

        public Arduino()
        {
            _arduinoSerialPort = new SerialPort();

            _arduinoSerialPort.PortName = List().ElementAt(List().Length - 1);
            _arduinoSerialPort.BaudRate = 57600;
            _arduinoSerialPort.DataBits = 8;
            _arduinoSerialPort.Parity = Parity.None;
            _arduinoSerialPort.StopBits = StopBits.One;

            Open();
        }
        public static string[] List()
        {
            return SerialPort.GetPortNames();
        }

        public void Open()
        {
            _arduinoSerialPort.DtrEnable = true;
            _arduinoSerialPort.Open();

            Thread.Sleep(4000);
        }
        public void Close()
        {
            if (_arduinoSerialPort.IsOpen == true)
            {
              _arduinoSerialPort.Close();
            }
           
        }
        public void pinMode(int pin, byte mode)
        {
            byte[] message = new byte[3];
            message[0] = (byte)(SET_PIN_MODE);
            message[1] = (byte)(pin);
            message[2] = (byte)(mode);
            _arduinoSerialPort.Write(message, 0, 3);
            message = null;
        }
        public void digitalWrite(int pin, byte value)
        {
            int portNumber = (pin >> 3) & 0x0F;
            byte[] message = new byte[3];

            if ((int)value == 0)
                _digitalOutputData[portNumber] &= ~(1 << (pin & 0x07));
            else
                _digitalOutputData[portNumber] |= (1 << (pin & 0x07));

            message[0] = (byte)(DIGITAL_MESSAGE | portNumber);
            message[1] = (byte)(_digitalOutputData[portNumber] & 0x7F);
            message[2] = (byte)(_digitalOutputData[portNumber] >> 7);
            _arduinoSerialPort.Write(message, 0, 3);
        }

        private const int MAX_DATA_BYTES = 64;
        private const int TOTAL_PORTS = 2;
        private const int DIGITAL_MESSAGE = 0x90; // send data for a digital port
        private const int SET_PIN_MODE = 0xF4; // set a pin to INPUT/OUTPUT/PWM/etc
        private volatile int[] _digitalOutputData = new int[MAX_DATA_BYTES];
        private SerialPort _arduinoSerialPort;
    }
}