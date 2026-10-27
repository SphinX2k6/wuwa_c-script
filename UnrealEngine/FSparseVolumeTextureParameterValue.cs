using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001165 RID: 4453
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SparseVolumeTextureParameterValue")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FSparseVolumeTextureParameterValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010451 RID: 66641 RVA: 0x0017F86C File Offset: 0x0017DA6C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSparseVolumeTextureParameterValue._ScriptStructPtr != 0) ? FSparseVolumeTextureParameterValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SparseVolumeTextureParameterValue", ref FSparseVolumeTextureParameterValue._ScriptStructPtr);
		}

		// Token: 0x17003FBC RID: 16316
		// (get) Token: 0x06010452 RID: 66642 RVA: 0x0017F890 File Offset: 0x0017DA90
		// (set) Token: 0x06010453 RID: 66643 RVA: 0x0017F8D3 File Offset: 0x0017DAD3
		public FMaterialParameterInfo ParameterInfo
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialParameterInfo result;
				if ((result = this._ParameterInfo) == null)
				{
					result = (this._ParameterInfo = new FMaterialParameterInfo(base.NativePtr + (IntPtr)FSparseVolumeTextureParameterValue.__PropertyOffset_ParameterInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialParameterInfo.StaticStruct(), base.NativePtr + (IntPtr)FSparseVolumeTextureParameterValue.__PropertyOffset_ParameterInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003FBD RID: 16317
		// (get) Token: 0x06010454 RID: 66644 RVA: 0x0017F8F4 File Offset: 0x0017DAF4
		// (set) Token: 0x06010455 RID: 66645 RVA: 0x0017F908 File Offset: 0x0017DB08
		[Nullable(2)]
		public unsafe USparseVolumeTexture ParameterValue
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USparseVolumeTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FSparseVolumeTextureParameterValue.__PropertyOffset_ParameterValue);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSparseVolumeTextureParameterValue.__PropertyOffset_ParameterValue, value);
			}
		}

		// Token: 0x17003FBE RID: 16318
		// (get) Token: 0x06010456 RID: 66646 RVA: 0x0017F91D File Offset: 0x0017DB1D
		// (set) Token: 0x06010457 RID: 66647 RVA: 0x0017F931 File Offset: 0x0017DB31
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSparseVolumeTextureParameterValue.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSparseVolumeTextureParameterValue.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x06010458 RID: 66648 RVA: 0x0017F946 File Offset: 0x0017DB46
		public FSparseVolumeTextureParameterValue()
		{
		}

		// Token: 0x06010459 RID: 66649 RVA: 0x0017F94E File Offset: 0x0017DB4E
		public FSparseVolumeTextureParameterValue(FMaterialParameterInfo ParameterInfo, USparseVolumeTexture ParameterValue, FGuid ExpressionGUID)
		{
			this.ParameterInfo = ParameterInfo;
			this.ParameterValue = ParameterValue;
			this.ExpressionGUID = ExpressionGUID;
		}

		// Token: 0x0601045A RID: 66650 RVA: 0x0017F96B File Offset: 0x0017DB6B
		protected override IntPtr GetUStructPtr()
		{
			return FSparseVolumeTextureParameterValue.StaticStruct();
		}

		// Token: 0x0601045B RID: 66651 RVA: 0x0017F977 File Offset: 0x0017DB77
		[NullableContext(2)]
		public FSparseVolumeTextureParameterValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601045C RID: 66652 RVA: 0x0017F981 File Offset: 0x0017DB81
		public FSparseVolumeTextureParameterValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601045D RID: 66653 RVA: 0x0017F98C File Offset: 0x0017DB8C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSparseVolumeTextureParameterValue(Pointer, false, true);
		}

		// Token: 0x0601045E RID: 66654 RVA: 0x0017F996 File Offset: 0x0017DB96
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSparseVolumeTextureParameterValue(Pointer, MemoryOwner);
		}

		// Token: 0x04008C0B RID: 35851
		public const string __ObjectPath = "/Script/Engine.SparseVolumeTextureParameterValue";

		// Token: 0x04008C0C RID: 35852
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008C0D RID: 35853
		internal static int __PropertyOffset_ParameterInfo;

		// Token: 0x04008C0E RID: 35854
		[Nullable(2)]
		private FMaterialParameterInfo _ParameterInfo;

		// Token: 0x04008C0F RID: 35855
		internal static int __PropertyOffset_ParameterValue;

		// Token: 0x04008C10 RID: 35856
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
