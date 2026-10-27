using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010C7 RID: 4295
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RuntimeVirtualTextureParameterValue")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FRuntimeVirtualTextureParameterValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F540 RID: 62784 RVA: 0x0016B802 File Offset: 0x00169A02
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRuntimeVirtualTextureParameterValue._ScriptStructPtr != 0) ? FRuntimeVirtualTextureParameterValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RuntimeVirtualTextureParameterValue", ref FRuntimeVirtualTextureParameterValue._ScriptStructPtr);
		}

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x0600F541 RID: 62785 RVA: 0x0016B828 File Offset: 0x00169A28
		// (set) Token: 0x0600F542 RID: 62786 RVA: 0x0016B86B File Offset: 0x00169A6B
		public FMaterialParameterInfo ParameterInfo
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialParameterInfo result;
				if ((result = this._ParameterInfo) == null)
				{
					result = (this._ParameterInfo = new FMaterialParameterInfo(base.NativePtr + (IntPtr)FRuntimeVirtualTextureParameterValue.__PropertyOffset_ParameterInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialParameterInfo.StaticStruct(), base.NativePtr + (IntPtr)FRuntimeVirtualTextureParameterValue.__PropertyOffset_ParameterInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x0600F543 RID: 62787 RVA: 0x0016B88C File Offset: 0x00169A8C
		// (set) Token: 0x0600F544 RID: 62788 RVA: 0x0016B8A0 File Offset: 0x00169AA0
		[Nullable(2)]
		public unsafe URuntimeVirtualTexture ParameterValue
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URuntimeVirtualTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FRuntimeVirtualTextureParameterValue.__PropertyOffset_ParameterValue);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRuntimeVirtualTextureParameterValue.__PropertyOffset_ParameterValue, value);
			}
		}

		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x0600F545 RID: 62789 RVA: 0x0016B8B5 File Offset: 0x00169AB5
		// (set) Token: 0x0600F546 RID: 62790 RVA: 0x0016B8C9 File Offset: 0x00169AC9
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimeVirtualTextureParameterValue.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimeVirtualTextureParameterValue.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0600F547 RID: 62791 RVA: 0x0016B8DE File Offset: 0x00169ADE
		public FRuntimeVirtualTextureParameterValue()
		{
		}

		// Token: 0x0600F548 RID: 62792 RVA: 0x0016B8E6 File Offset: 0x00169AE6
		public FRuntimeVirtualTextureParameterValue(FMaterialParameterInfo ParameterInfo, URuntimeVirtualTexture ParameterValue, FGuid ExpressionGUID)
		{
			this.ParameterInfo = ParameterInfo;
			this.ParameterValue = ParameterValue;
			this.ExpressionGUID = ExpressionGUID;
		}

		// Token: 0x0600F549 RID: 62793 RVA: 0x0016B903 File Offset: 0x00169B03
		protected override IntPtr GetUStructPtr()
		{
			return FRuntimeVirtualTextureParameterValue.StaticStruct();
		}

		// Token: 0x0600F54A RID: 62794 RVA: 0x0016B90F File Offset: 0x00169B0F
		[NullableContext(2)]
		public FRuntimeVirtualTextureParameterValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F54B RID: 62795 RVA: 0x0016B919 File Offset: 0x00169B19
		public FRuntimeVirtualTextureParameterValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F54C RID: 62796 RVA: 0x0016B924 File Offset: 0x00169B24
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRuntimeVirtualTextureParameterValue(Pointer, false, true);
		}

		// Token: 0x0600F54D RID: 62797 RVA: 0x0016B92E File Offset: 0x00169B2E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRuntimeVirtualTextureParameterValue(Pointer, MemoryOwner);
		}

		// Token: 0x040084E2 RID: 34018
		public const string __ObjectPath = "/Script/Engine.RuntimeVirtualTextureParameterValue";

		// Token: 0x040084E3 RID: 34019
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040084E4 RID: 34020
		internal static int __PropertyOffset_ParameterInfo;

		// Token: 0x040084E5 RID: 34021
		[Nullable(2)]
		private FMaterialParameterInfo _ParameterInfo;

		// Token: 0x040084E6 RID: 34022
		internal static int __PropertyOffset_ParameterValue;

		// Token: 0x040084E7 RID: 34023
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
