using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A93 RID: 6803
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.FruitActiveState")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FFruitActiveState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019180 RID: 102784 RVA: 0x00250D61 File Offset: 0x0024EF61
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFruitActiveState._ScriptStructPtr != 0) ? FFruitActiveState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.FruitActiveState", ref FFruitActiveState._ScriptStructPtr);
		}

		// Token: 0x170063B0 RID: 25520
		// (get) Token: 0x06019181 RID: 102785 RVA: 0x00250D85 File Offset: 0x0024EF85
		// (set) Token: 0x06019182 RID: 102786 RVA: 0x00250D99 File Offset: 0x0024EF99
		[Nullable(2)]
		public unsafe UStaticMeshComponent SMC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FFruitActiveState.__PropertyOffset_SMC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FFruitActiveState.__PropertyOffset_SMC, value);
			}
		}

		// Token: 0x06019183 RID: 102787 RVA: 0x00250DAE File Offset: 0x0024EFAE
		public FFruitActiveState()
		{
		}

		// Token: 0x06019184 RID: 102788 RVA: 0x00250DB6 File Offset: 0x0024EFB6
		[NullableContext(1)]
		public FFruitActiveState(UStaticMeshComponent SMC)
		{
			this.SMC = SMC;
		}

		// Token: 0x06019185 RID: 102789 RVA: 0x00250DC5 File Offset: 0x0024EFC5
		protected override IntPtr GetUStructPtr()
		{
			return FFruitActiveState.StaticStruct();
		}

		// Token: 0x06019186 RID: 102790 RVA: 0x00250DD1 File Offset: 0x0024EFD1
		[NullableContext(2)]
		public FFruitActiveState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019187 RID: 102791 RVA: 0x00250DDB File Offset: 0x0024EFDB
		public FFruitActiveState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019188 RID: 102792 RVA: 0x00250DE6 File Offset: 0x0024EFE6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFruitActiveState(Pointer, false, true);
		}

		// Token: 0x06019189 RID: 102793 RVA: 0x00250DF0 File Offset: 0x0024EFF0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFruitActiveState(Pointer, MemoryOwner);
		}

		// Token: 0x0400DACF RID: 56015
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.FruitActiveState";

		// Token: 0x0400DAD0 RID: 56016
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DAD1 RID: 56017
		internal static int __PropertyOffset_SMC;
	}
}
