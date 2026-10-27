using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014ED RID: 5357
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterFile")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UHoudiniParameterFile : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601368A RID: 79498 RVA: 0x001C8969 File Offset: 0x001C6B69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterFile._ClassPtr;
		}

		// Token: 0x0601368B RID: 79499 RVA: 0x001C8978 File Offset: 0x001C6B78
		public UHoudiniParameterFile() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterFile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601368C RID: 79500 RVA: 0x001C89A0 File Offset: 0x001C6BA0
		public UHoudiniParameterFile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterFile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BC0 RID: 19392
		// (get) Token: 0x0601368D RID: 79501 RVA: 0x001C89D4 File Offset: 0x001C6BD4
		// (set) Token: 0x0601368E RID: 79502 RVA: 0x001C8A0D File Offset: 0x001C6C0D
		public TArray<string> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<string>(base.NativePtr + (IntPtr)UHoudiniParameterFile.__PropertyOffset_Values, this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x17004BC1 RID: 19393
		// (get) Token: 0x0601368F RID: 79503 RVA: 0x001C8A1C File Offset: 0x001C6C1C
		// (set) Token: 0x06013690 RID: 79504 RVA: 0x001C8A55 File Offset: 0x001C6C55
		public TArray<string> DefaultValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DefaultValues) == null)
				{
					result = (this._DefaultValues = new TArray<string>(base.NativePtr + (IntPtr)UHoudiniParameterFile.__PropertyOffset_DefaultValues, this));
				}
				return result;
			}
			set
			{
				this.DefaultValues.CopyAssign(value);
			}
		}

		// Token: 0x17004BC2 RID: 19394
		// (get) Token: 0x06013691 RID: 79505 RVA: 0x001C8A63 File Offset: 0x001C6C63
		// (set) Token: 0x06013692 RID: 79506 RVA: 0x001C8A77 File Offset: 0x001C6C77
		public unsafe string Filters
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameterFile.__PropertyOffset_Filters)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameterFile.__PropertyOffset_Filters)), value);
			}
		}

		// Token: 0x17004BC3 RID: 19395
		// (get) Token: 0x06013693 RID: 79507 RVA: 0x001C8A8C File Offset: 0x001C6C8C
		// (set) Token: 0x06013694 RID: 79508 RVA: 0x001C8A9C File Offset: 0x001C6C9C
		public unsafe bool bIsReadOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFile.__PropertyOffset_bIsReadOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFile.__PropertyOffset_bIsReadOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013695 RID: 79509 RVA: 0x001C8AAD File Offset: 0x001C6CAD
		static UHoudiniParameterFile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterFile");
		}

		// Token: 0x06013696 RID: 79510 RVA: 0x001C8ABB File Offset: 0x001C6CBB
		protected UHoudiniParameterFile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A7CB RID: 42955
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterFile";

		// Token: 0x0400A7CC RID: 42956
		private static IntPtr _ClassPtr;

		// Token: 0x0400A7CD RID: 42957
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A7CE RID: 42958
		internal static int __PropertyOffset_Values;

		// Token: 0x0400A7CF RID: 42959
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Values;

		// Token: 0x0400A7D0 RID: 42960
		internal static int __PropertyOffset_DefaultValues;

		// Token: 0x0400A7D1 RID: 42961
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DefaultValues;

		// Token: 0x0400A7D2 RID: 42962
		internal static int __PropertyOffset_Filters;

		// Token: 0x0400A7D3 RID: 42963
		internal static int __PropertyOffset_bIsReadOnly;
	}
}
