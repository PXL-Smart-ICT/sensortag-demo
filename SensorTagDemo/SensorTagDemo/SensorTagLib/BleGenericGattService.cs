﻿using Robotics.Mobile.Core.Bluetooth.LE;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorTagLib
{
    public abstract class BleGenericGattService
    {
        protected IService _service;
        protected List<ICharacteristic> _characteristics;
        protected IDevice _connectedDevice;
        protected IAdapter _adapter;
        protected bool _connected;
        protected bool _disconnecting;
        protected HashSet<Guid> _requestedCharacteristics = new HashSet<Guid>();

        public BleGenericGattService(IAdapter adapter, IService service)
        {
            _adapter = adapter;
            _service = service;
        }

        
    }
}
