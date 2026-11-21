using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200029E RID: 670
	[UnrealObjectPath("/Script/Engine.TextureParameterValue")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FTextureParameterValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004983 RID: 18819 RVA: 0x00067168 File Offset: 0x00065368
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextureParameterValue._ScriptStructPtr != 0) ? FTextureParameterValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TextureParameterValue", ref FTextureParameterValue._ScriptStructPtr);
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06004984 RID: 18820 RVA: 0x0006718C File Offset: 0x0006538C
		// (set) Token: 0x06004985 RID: 18821 RVA: 0x000671A0 File Offset: 0x000653A0
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

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06004986 RID: 18822 RVA: 0x000671B5 File Offset: 0x000653B5
		// (set) Token: 0x06004987 RID: 18823 RVA: 0x000671C9 File Offset: 0x000653C9
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

		// Token: 0x06004988 RID: 18824 RVA: 0x000671DE File Offset: 0x000653DE
		public FTextureParameterValue()
		{
		}

		// Token: 0x06004989 RID: 18825 RVA: 0x000671E6 File Offset: 0x000653E6
		protected override IntPtr GetUStructPtr()
		{
			return FTextureParameterValue.StaticStruct();
		}

		// Token: 0x0600498A RID: 18826 RVA: 0x000671F2 File Offset: 0x000653F2
		[NullableContext(2)]
		public FTextureParameterValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x000671FC File Offset: 0x000653FC
		public FTextureParameterValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x00067207 File Offset: 0x00065407
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextureParameterValue(Pointer, false, true);
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x00067211 File Offset: 0x00065411
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextureParameterValue(Pointer, MemoryOwner);
		}

		// Token: 0x04001CEC RID: 7404
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TextureParameterValue";

		// Token: 0x04001CED RID: 7405
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001CEE RID: 7406
		internal static int __PropertyOffset_ParameterValue;

		// Token: 0x04001CEF RID: 7407
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
