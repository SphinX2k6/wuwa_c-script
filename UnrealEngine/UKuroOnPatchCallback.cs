using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005A7 RID: 1447
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSoHotPatch.KuroOnPatchCallback")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroOnPatchCallback : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600826B RID: 33387 RVA: 0x000C0D8A File Offset: 0x000BEF8A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroOnPatchCallback._ClassPtr;
		}

		// Token: 0x0600826C RID: 33388 RVA: 0x000C0D98 File Offset: 0x000BEF98
		public UKuroOnPatchCallback() : this(BuiltinUtils.AllocNativeUObject(UKuroOnPatchCallback.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600826D RID: 33389 RVA: 0x000C0DC0 File Offset: 0x000BEFC0
		public UKuroOnPatchCallback(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroOnPatchCallback.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x0600826E RID: 33390 RVA: 0x000C0DF4 File Offset: 0x000BEFF4
		// (set) Token: 0x0600826F RID: 33391 RVA: 0x000C0E2D File Offset: 0x000BF02D
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

		// Token: 0x06008270 RID: 33392 RVA: 0x000C0E4E File Offset: 0x000BF04E
		[NullableContext(2)]
		public static UKuroOnPatchCallback GetInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroOnPatchCallback>(UKuroOnPatchCallback.__GetInstance_Internal());
		}

		// Token: 0x06008271 RID: 33393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal();

		// Token: 0x06008272 RID: 33394 RVA: 0x000C0E5A File Offset: 0x000BF05A
		static UKuroOnPatchCallback()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSoHotPatch.KuroOnPatchCallback");
		}

		// Token: 0x06008273 RID: 33395 RVA: 0x000C0E68 File Offset: 0x000BF068
		protected UKuroOnPatchCallback(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040038D0 RID: 14544
		public new const string __ObjectPath = "/Script/KuroSoHotPatch.KuroOnPatchCallback";

		// Token: 0x040038D1 RID: 14545
		private static IntPtr _ClassPtr;

		// Token: 0x040038D2 RID: 14546
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040038D3 RID: 14547
		internal static int __PropertyOffset_Callback;

		// Token: 0x040038D4 RID: 14548
		[Nullable(2)]
		private FKuroOnPatchResultDelegate _Callback;
	}
}
