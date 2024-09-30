using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkiyeSporSisemi.ConsoleUI.Exceptions;

public class ValidationException(string msg) : Exception(msg);
