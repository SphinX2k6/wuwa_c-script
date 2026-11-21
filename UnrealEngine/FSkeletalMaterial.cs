using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200027D RID: 637
	[UnrealObjectPath("/Script/Engine.SkeletalMaterial")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FSkeletalMaterial : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004200 RID: 16896 RVA: 0x0005E56E File Offset: 0x0005C76E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMaterial._ScriptStructPtr != 0) ? FSkeletalMaterial._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMaterial", ref FSkeletalMaterial._ScriptStructPtr);
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06004201 RID: 16897 RVA: 0x0005E592 File Offset: 0x0005C792
		// (set) Token: 0x06004202 RID: 16898 RVA: 0x0005E5A6 File Offset: 0x0005C7A6
		[Nullable(2)]
		public unsafe UMaterialInterface MaterialInterface
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FSkeletalMaterial.__PropertyOffset_MaterialInterface);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSkeletalMaterial.__PropertyOffset_MaterialInterface, value);
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06004203 RID: 16899 RVA: 0x0005E5BB File Offset: 0x0005C7BB
		// (set) Token: 0x06004204 RID: 16900 RVA: 0x0005E5CF File Offset: 0x0005C7CF
		public unsafe FName MaterialSlotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMaterial.__PropertyOffset_MaterialSlotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMaterial.__PropertyOffset_MaterialSlotName) = value;
			}
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x0005E5E4 File Offset: 0x0005C7E4
		public FSkeletalMaterial()
		{
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x0005E5EC File Offset: 0x0005C7EC
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMaterial.StaticStruct();
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x0005E5F8 File Offset: 0x0005C7F8
		[NullableContext(2)]
		public FSkeletalMaterial(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x0005E602 File Offset: 0x0005C802
		public FSkeletalMaterial(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x0005E60D File Offset: 0x0005C80D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMaterial(Pointer, false, true);
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x0005E617 File Offset: 0x0005C817
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMaterial(Pointer, MemoryOwner);
		}

		// Token: 0x040019D1 RID: 6609
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SkeletalMaterial";

		// Token: 0x040019D2 RID: 6610
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040019D3 RID: 6611
		internal static int __PropertyOffset_MaterialInterface;

		// Token: 0x040019D4 RID: 6612
		internal static int __PropertyOffset_MaterialSlotName;
	}
}
