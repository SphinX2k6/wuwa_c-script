using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E8D RID: 7821
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.AsyncLoadState")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAsyncLoadState : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DC0C RID: 121868 RVA: 0x002BF586 File Offset: 0x002BD786
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncLoadState._ClassPtr;
		}

		// Token: 0x0601DC0D RID: 121869 RVA: 0x002BF594 File Offset: 0x002BD794
		public UAsyncLoadState() : this(BuiltinUtils.AllocNativeUObject(UAsyncLoadState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DC0E RID: 121870 RVA: 0x002BF5BC File Offset: 0x002BD7BC
		public UAsyncLoadState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncLoadState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007783 RID: 30595
		// (get) Token: 0x0601DC0F RID: 121871 RVA: 0x002BF5F0 File Offset: 0x002BD7F0
		// (set) Token: 0x0601DC10 RID: 121872 RVA: 0x002BF629 File Offset: 0x002BD829
		public FClassLoadedDelegate ClassLoadedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FClassLoadedDelegate result;
				if ((result = this._ClassLoadedDelegate) == null)
				{
					result = (this._ClassLoadedDelegate = new FClassLoadedDelegate(base.NativePtr + (IntPtr)UAsyncLoadState.__PropertyOffset_ClassLoadedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncLoadState.__PropertyOffset_ClassLoadedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007784 RID: 30596
		// (get) Token: 0x0601DC11 RID: 121873 RVA: 0x002BF64C File Offset: 0x002BD84C
		// (set) Token: 0x0601DC12 RID: 121874 RVA: 0x002BF685 File Offset: 0x002BD885
		public FObjectLoadedDelegate ObjectLoadedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FObjectLoadedDelegate result;
				if ((result = this._ObjectLoadedDelegate) == null)
				{
					result = (this._ObjectLoadedDelegate = new FObjectLoadedDelegate(base.NativePtr + (IntPtr)UAsyncLoadState.__PropertyOffset_ObjectLoadedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncLoadState.__PropertyOffset_ObjectLoadedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601DC13 RID: 121875 RVA: 0x002BF6A8 File Offset: 0x002BD8A8
		public unsafe void AsyncLoadObject(string InPath, [Nullable(2)] UObject UserData = null)
		{
			FString fstring = FString.AllocTemp(InPath);
			UAsyncLoadState.__AsyncLoadObject_Internal(base.NativePtr, fstring, (UserData != null) ? UserData.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DC14 RID: 121876 RVA: 0x002BF6E4 File Offset: 0x002BD8E4
		public unsafe void AsyncLoadClass(string InPath, [Nullable(2)] UObject UserData = null)
		{
			FString fstring = FString.AllocTemp(InPath);
			UAsyncLoadState.__AsyncLoadClass_Internal(base.NativePtr, fstring, (UserData != null) ? UserData.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DC15 RID: 121877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AsyncLoadObject_Internal(IntPtr @this, in FString InPath, IntPtr UserData);

		// Token: 0x0601DC16 RID: 121878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AsyncLoadClass_Internal(IntPtr @this, in FString InPath, IntPtr UserData);

		// Token: 0x0601DC17 RID: 121879 RVA: 0x002BF71E File Offset: 0x002BD91E
		static UAsyncLoadState()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.AsyncLoadState");
		}

		// Token: 0x0601DC18 RID: 121880 RVA: 0x002BF72C File Offset: 0x002BD92C
		protected UAsyncLoadState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040101C0 RID: 65984
		public new const string __ObjectPath = "/Script/KuroUtility.AsyncLoadState";

		// Token: 0x040101C1 RID: 65985
		private static IntPtr _ClassPtr;

		// Token: 0x040101C2 RID: 65986
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040101C3 RID: 65987
		internal static int __PropertyOffset_ClassLoadedDelegate;

		// Token: 0x040101C4 RID: 65988
		[Nullable(2)]
		private FClassLoadedDelegate _ClassLoadedDelegate;

		// Token: 0x040101C5 RID: 65989
		internal static int __PropertyOffset_ObjectLoadedDelegate;

		// Token: 0x040101C6 RID: 65990
		[Nullable(2)]
		private FObjectLoadedDelegate _ObjectLoadedDelegate;
	}
}
