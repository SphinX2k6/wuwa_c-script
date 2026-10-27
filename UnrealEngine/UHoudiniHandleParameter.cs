using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014C7 RID: 5319
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniHandleParameter")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UHoudiniHandleParameter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013415 RID: 78869 RVA: 0x001C50C6 File Offset: 0x001C32C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniHandleParameter._ClassPtr;
		}

		// Token: 0x06013416 RID: 78870 RVA: 0x001C50D4 File Offset: 0x001C32D4
		public UHoudiniHandleParameter() : this(BuiltinUtils.AllocNativeUObject(UHoudiniHandleParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013417 RID: 78871 RVA: 0x001C50FC File Offset: 0x001C32FC
		[NullableContext(1)]
		public UHoudiniHandleParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniHandleParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004AEB RID: 19179
		// (get) Token: 0x06013418 RID: 78872 RVA: 0x001C512F File Offset: 0x001C332F
		// (set) Token: 0x06013419 RID: 78873 RVA: 0x001C5143 File Offset: 0x001C3343
		[Nullable(2)]
		public unsafe UHoudiniParameter AssetParameter
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniParameter>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniHandleParameter.__PropertyOffset_AssetParameter);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniHandleParameter.__PropertyOffset_AssetParameter, value);
			}
		}

		// Token: 0x17004AEC RID: 19180
		// (get) Token: 0x0601341A RID: 78874 RVA: 0x001C5158 File Offset: 0x001C3358
		// (set) Token: 0x0601341B RID: 78875 RVA: 0x001C5168 File Offset: 0x001C3368
		public unsafe int TupleIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniHandleParameter.__PropertyOffset_TupleIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniHandleParameter.__PropertyOffset_TupleIndex) = value;
			}
		}

		// Token: 0x0601341C RID: 78876 RVA: 0x001C5179 File Offset: 0x001C3379
		static UHoudiniHandleParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniHandleParameter");
		}

		// Token: 0x0601341D RID: 78877 RVA: 0x001C5187 File Offset: 0x001C3387
		protected UHoudiniHandleParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A656 RID: 42582
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniHandleParameter";

		// Token: 0x0400A657 RID: 42583
		private static IntPtr _ClassPtr;

		// Token: 0x0400A658 RID: 42584
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A659 RID: 42585
		internal static int __PropertyOffset_AssetParameter;

		// Token: 0x0400A65A RID: 42586
		internal static int __PropertyOffset_TupleIndex;
	}
}
