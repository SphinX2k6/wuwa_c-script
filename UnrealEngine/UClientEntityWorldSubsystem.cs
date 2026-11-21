using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A6 RID: 422
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ClientEntityWorldSubsystem")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UClientEntityWorldSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001F77 RID: 8055 RVA: 0x0002D848 File Offset: 0x0002BA48
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClientEntityWorldSubsystem._ClassPtr;
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x0002D854 File Offset: 0x0002BA54
		public UClientEntityWorldSubsystem() : this(BuiltinUtils.AllocNativeUObject(UClientEntityWorldSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x0002D87C File Offset: 0x0002BA7C
		public UClientEntityWorldSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClientEntityWorldSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x0002D8B0 File Offset: 0x0002BAB0
		// (set) Token: 0x06001F7B RID: 8059 RVA: 0x0002D8E9 File Offset: 0x0002BAE9
		public FOnClientEntityStreamingStateChanged OnClientEntityStreamingStateChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnClientEntityStreamingStateChanged result;
				if ((result = this._OnClientEntityStreamingStateChanged) == null)
				{
					result = (this._OnClientEntityStreamingStateChanged = new FOnClientEntityStreamingStateChanged(base.NativePtr + (IntPtr)UClientEntityWorldSubsystem.__PropertyOffset_OnClientEntityStreamingStateChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UClientEntityWorldSubsystem.__PropertyOffset_OnClientEntityStreamingStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x0002D90A File Offset: 0x0002BB0A
		[NullableContext(2)]
		public void SetValidPackIds(in TArray<int> InPackIds)
		{
			UClientEntityWorldSubsystem.__SetValidPackIds_Internal(base.NativePtr, (InPackIds ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06001F7D RID: 8061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValidPackIds_Internal(IntPtr @this, IntPtr InPackIds);

		// Token: 0x06001F7E RID: 8062 RVA: 0x0002D927 File Offset: 0x0002BB27
		static UClientEntityWorldSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ClientEntityWorldSubsystem");
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x0002D935 File Offset: 0x0002BB35
		protected UClientEntityWorldSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A69 RID: 2665
		public new const string __ObjectPath = "/Script/Engine.ClientEntityWorldSubsystem";

		// Token: 0x04000A6A RID: 2666
		private static IntPtr _ClassPtr;

		// Token: 0x04000A6B RID: 2667
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A6C RID: 2668
		internal static int __PropertyOffset_OnClientEntityStreamingStateChanged;

		// Token: 0x04000A6D RID: 2669
		[Nullable(2)]
		private FOnClientEntityStreamingStateChanged _OnClientEntityStreamingStateChanged;
	}
}
