﻿using System;

namespace BTCPayServer.Plugins.Bringin;

public class BringinException : Exception
{
    private readonly BringinClient.BringinErrorResponse _error;

    public BringinException(BringinClient.BringinErrorResponse error)
    {
        _error = error;
    }
}