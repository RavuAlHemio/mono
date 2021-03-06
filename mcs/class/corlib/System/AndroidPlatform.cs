// 
// System.AndroidPlatform.cs
//
// Author:
//   Jonathan Pryor (jonp@xamarin.com)
//
// Copyright (C) 2012 Xamarin Inc (http://xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#if MONODROID
using System.Reflection;
using System.Threading;

namespace System {

	internal class AndroidPlatform {

		static readonly Func<SynchronizationContext> getDefaultSyncContext;
		static readonly Func<string> getDefaultTimeZone;

		static AndroidPlatform ()
		{
			Type androidRuntime = Type.GetType ("Android.Runtime.AndroidEnvironment, Mono.Android", true);

			getDefaultSyncContext = (Func<SynchronizationContext>)
				Delegate.CreateDelegate (typeof(Func<SynchronizationContext>), 
						androidRuntime.GetMethod ("GetDefaultSyncContext",
							System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic));

			getDefaultTimeZone = (Func<string>)
				Delegate.CreateDelegate (typeof(Func<string>), 
						androidRuntime.GetMethod ("GetDefaultTimeZone",
							System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic));
		}

		internal static SynchronizationContext GetDefaultSyncContext ()
		{
			return getDefaultSyncContext ();
		}

		internal static string GetDefaultTimeZone ()
		{
			return getDefaultTimeZone ();
		}
	}
}
#endif
