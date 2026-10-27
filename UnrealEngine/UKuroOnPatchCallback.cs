using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E74 RID: 7796
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSoHotPatch.KuroOnPatchCallback")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroOnPatchCallback : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DB01 RID: 121601 RVA: 0x002BDAAE File Offset: 0x002BBCAE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroOnPatchCallback._ClassPtr;
		}

		// Token: 0x0601DB02 RID: 121602 RVA: 0x002BDABC File Offset: 0x002BBCBC
		public UKuroOnPatchCallback() : this(BuiltinUtils.AllocNativeUObject(UKuroOnPatchCallback.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DB03 RID: 121603 RVA: 0x002BDAE4 File Offset: 0x002BBCE4
		public UKuroOnPatchCallback(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroOnPatchCallback.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700776E RID: 30574
		// (get) Token: 0x0601DB04 RID: 121604 RVA: 0x002BDB18 File Offset: 0x002BBD18
		// (set) Token: 0x0601DB05 RID: 121605 RVA: 0x002BDB51 File Offset: 0x002BBD51
		public FKuroOnPatchResultDelegate Callback
		{
			get
			{
				base.FastCheckIsValid();
				FKuroOnPatchResultDelegate result;
				if ((result = this._Callback) == null)
				{
					result = (this._Callback = new FKuroOnPatchResultDelegate(base.NativePtr + (IntPtr)UKuroOnPatchCallback.__PropertyOffset_Callback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroOnPatchCallback.__PropertyOffset_Callback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601DB06 RID: 121606 RVA: 0x002BDB72 File Offset: 0x002BBD72
		[NullableContext(2)]
		public static UKuroOnPatchCallback GetInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroOnPatchCallback>(UKuroOnPatchCallback.__GetInstance_Internal());
		}

		// Token: 0x0601DB07 RID: 121607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal();

		// Token: 0x0601DB08 RID: 121608 RVA: 0x002BDB7E File Offset: 0x002BBD7E
		static UKuroOnPatchCallback()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSoHotPatch.KuroOnPatchCallback");
		}

		// Token: 0x0601DB09 RID: 121609 RVA: 0x002BDB8C File Offset: 0x002BBD8C
		protected UKuroOnPatchCallback(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401013B RID: 65851
		public new const string __ObjectPath = "/Script/KuroSoHotPatch.KuroOnPatchCallback";

		// Token: 0x0401013C RID: 65852
		private static IntPtr _ClassPtr;

		// Token: 0x0401013D RID: 65853
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401013E RID: 65854
		internal static int __PropertyOffset_Callback;

		// Token: 0x0401013F RID: 65855
		[Nullable(2)]
		private FKuroOnPatchResultDelegate _Callback;
	}
}
