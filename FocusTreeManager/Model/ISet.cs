﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTreeManager.Model
{
    [ProtoContract]
    public interface ISet
    {
        void DeleteSetRelations();
        bool assertInternalFocus(Focus focus, bool set = true);
    }
}
