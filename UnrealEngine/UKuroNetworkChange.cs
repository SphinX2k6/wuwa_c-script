using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019FB RID: 6651
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroNetwork.KuroNetworkChange")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroNetworkChange : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018A8B RID: 101003 RVA: 0x00245D9F File Offset: 0x00243F9F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroNetworkChange._ClassPtr;
		}

		// Token: 0x06018A8C RID: 101004 RVA: 0x00245DAC File Offset: 0x00243FAC
		public UKuroNetworkChange() : this(BuiltinUtils.AllocNativeUObject(UKuroNetworkChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018A8D RID: 101005 RVA: 0x00245DD4 File Offset: 0x00243FD4
		public UKuroNetworkChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroNetworkChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700620C RID: 25100
		// (get) Token: 0x06018A8E RID: 101006 RVA: 0x00245E08 File Offset: 0x00244008
		// (set) Token: 0x06018A8F RID: 101007 RVA: 0x00245E41 File Offset: 0x00244041
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

		// Token: 0x06018A90 RID: 101008 RVA: 0x00245E62 File Offset: 0x00244062
		public byte GetNetworkType()
		{
			return UKuroNetworkChange.__GetNetworkType_Internal(base.NativePtr);
		}

		// Token: 0x06018A91 RID: 101009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetNetworkType_Internal(IntPtr @this);

		// Token: 0x06018A92 RID: 101010 RVA: 0x00245E6F File Offset: 0x0024406F
		static UKuroNetworkChange()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroNetworkChange");
		}

		// Token: 0x06018A93 RID: 101011 RVA: 0x00245E7D File Offset: 0x0024407D
		protected UKuroNetworkChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D535 RID: 54581
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroNetworkChange";

		// Token: 0x0400D536 RID: 54582
		private static IntPtr _ClassPtr;

		// Token: 0x0400D537 RID: 54583
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D538 RID: 54584
		internal static int __PropertyOffset_NetworkChangeDelegate;

		// Token: 0x0400D539 RID: 54585
		[Nullable(2)]
		private FKuroNetworkChangeDelegate _NetworkChangeDelegate;
	}
}
