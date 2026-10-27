using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011DC RID: 4572
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TextureParameterValue")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FTextureParameterValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010D64 RID: 68964 RVA: 0x0018B9AD File Offset: 0x00189BAD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextureParameterValue._ScriptStructPtr != 0) ? FTextureParameterValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TextureParameterValue", ref FTextureParameterValue._ScriptStructPtr);
		}

		// Token: 0x170041C8 RID: 16840
		// (get) Token: 0x06010D65 RID: 68965 RVA: 0x0018B9D4 File Offset: 0x00189BD4
		// (set) Token: 0x06010D66 RID: 68966 RVA: 0x0018BA17 File Offset: 0x00189C17
		public FMaterialParameterInfo ParameterInfo
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialParameterInfo result;
				if ((result = this._ParameterInfo) == null)
				{
					result = (this._ParameterInfo = new FMaterialParameterInfo(base.NativePtr + (IntPtr)FTextureParameterValue.__PropertyOffset_ParameterInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialParameterInfo.StaticStruct(), base.NativePtr + (IntPtr)FTextureParameterValue.__PropertyOffset_ParameterInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170041C9 RID: 16841
		// (get) Token: 0x06010D67 RID: 68967 RVA: 0x0018BA38 File Offset: 0x00189C38
		// (set) Token: 0x06010D68 RID: 68968 RVA: 0x0018BA4C File Offset: 0x00189C4C
		[Nullable(2)]
		public unsafe UTexture ParameterValue
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FTextureParameterValue.__PropertyOffset_ParameterValue);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTextureParameterValue.__PropertyOffset_ParameterValue, value);
			}
		}

		// Token: 0x170041CA RID: 16842
		// (get) Token: 0x06010D69 RID: 68969 RVA: 0x0018BA61 File Offset: 0x00189C61
		// (set) Token: 0x06010D6A RID: 68970 RVA: 0x0018BA75 File Offset: 0x00189C75
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureParameterValue.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureParameterValue.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x06010D6B RID: 68971 RVA: 0x0018BA8A File Offset: 0x00189C8A
		public FTextureParameterValue()
		{
		}

		// Token: 0x06010D6C RID: 68972 RVA: 0x0018BA92 File Offset: 0x00189C92
		public FTextureParameterValue(FName ParameterName_DEPRECATED, FMaterialParameterInfo ParameterInfo, UTexture ParameterValue, FGuid ExpressionGUID)
		{
			this.ParameterInfo = ParameterInfo;
			this.ParameterValue = ParameterValue;
			this.ExpressionGUID = ExpressionGUID;
		}

		// Token: 0x06010D6D RID: 68973 RVA: 0x0018BAB0 File Offset: 0x00189CB0
		protected override IntPtr GetUStructPtr()
		{
			return FTextureParameterValue.StaticStruct();
		}

		// Token: 0x06010D6E RID: 68974 RVA: 0x0018BABC File Offset: 0x00189CBC
		[NullableContext(2)]
		public FTextureParameterValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010D6F RID: 68975 RVA: 0x0018BAC6 File Offset: 0x00189CC6
		public FTextureParameterValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010D70 RID: 68976 RVA: 0x0018BAD1 File Offset: 0x00189CD1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextureParameterValue(Pointer, false, true);
		}

		// Token: 0x06010D71 RID: 68977 RVA: 0x0018BADB File Offset: 0x00189CDB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextureParameterValue(Pointer, MemoryOwner);
		}

		// Token: 0x0400905F RID: 36959
		public const string __ObjectPath = "/Script/Engine.TextureParameterValue";

		// Token: 0x04009060 RID: 36960
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009061 RID: 36961
		internal static int __PropertyOffset_ParameterInfo;

		// Token: 0x04009062 RID: 36962
		[Nullable(2)]
		private FMaterialParameterInfo _ParameterInfo;

		// Token: 0x04009063 RID: 36963
		internal static int __PropertyOffset_ParameterValue;

		// Token: 0x04009064 RID: 36964
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
