using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000480 RID: 1152
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroNetwork.KuroNetworkChange")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroNetworkChange : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006CFD RID: 27901 RVA: 0x0009F394 File Offset: 0x0009D594
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroNetworkChange._ClassPtr;
		}

		// Token: 0x06006CFE RID: 27902 RVA: 0x0009F3A0 File Offset: 0x0009D5A0
		public UKuroNetworkChange() : this(BuiltinUtils.AllocNativeUObject(UKuroNetworkChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006CFF RID: 27903 RVA: 0x0009F3C8 File Offset: 0x0009D5C8
		public UKuroNetworkChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroNetworkChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06006D00 RID: 27904 RVA: 0x0009F3FC File Offset: 0x0009D5FC
		// (set) Token: 0x06006D01 RID: 27905 RVA: 0x0009F435 File Offset: 0x0009D635
		public FKuroNetworkChangeDelegate NetworkChangeDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FKuroNetworkChangeDelegate result;
				if ((result = this._NetworkChangeDelegate) == null)
				{
					result = (this._NetworkChangeDelegate = new FKuroNetworkChangeDelegate(base.NativePtr + (IntPtr)UKuroNetworkChange.__PropertyOffset_NetworkChangeDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroNetworkChange.__PropertyOffset_NetworkChangeDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06006D02 RID: 27906 RVA: 0x0009F456 File Offset: 0x0009D656
		public byte GetNetworkType()
		{
			return UKuroNetworkChange.__GetNetworkType_Internal(base.NativePtr);
		}

		// Token: 0x06006D03 RID: 27907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetNetworkType_Internal(IntPtr @this);

		// Token: 0x06006D04 RID: 27908 RVA: 0x0009F463 File Offset: 0x0009D663
		static UKuroNetworkChange()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroNetworkChange");
		}

		// Token: 0x06006D05 RID: 27909 RVA: 0x0009F471 File Offset: 0x0009D671
		protected UKuroNetworkChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E8F RID: 11919
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroNetworkChange";

		// Token: 0x04002E90 RID: 11920
		private static IntPtr _ClassPtr;

		// Token: 0x04002E91 RID: 11921
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002E92 RID: 11922
		internal static int __PropertyOffset_NetworkChangeDelegate;

		// Token: 0x04002E93 RID: 11923
		[Nullable(2)]
		private FKuroNetworkChangeDelegate _NetworkChangeDelegate;
	}
}
