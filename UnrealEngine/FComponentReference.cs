using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000960 RID: 2400
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ComponentReference")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FComponentReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060087A1 RID: 34721 RVA: 0x000C23B1 File Offset: 0x000C05B1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FComponentReference._ScriptStructPtr != 0) ? FComponentReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ComponentReference", ref FComponentReference._ScriptStructPtr);
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x060087A2 RID: 34722 RVA: 0x000C23D5 File Offset: 0x000C05D5
		// (set) Token: 0x060087A3 RID: 34723 RVA: 0x000C23E9 File Offset: 0x000C05E9
		[Nullable(2)]
		public unsafe AActor OtherActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FComponentReference.__PropertyOffset_OtherActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FComponentReference.__PropertyOffset_OtherActor, value);
			}
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x060087A4 RID: 34724 RVA: 0x000C23FE File Offset: 0x000C05FE
		// (set) Token: 0x060087A5 RID: 34725 RVA: 0x000C2412 File Offset: 0x000C0612
		public unsafe FName ComponentProperty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentReference.__PropertyOffset_ComponentProperty);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentReference.__PropertyOffset_ComponentProperty) = value;
			}
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x060087A6 RID: 34726 RVA: 0x000C2427 File Offset: 0x000C0627
		// (set) Token: 0x060087A7 RID: 34727 RVA: 0x000C243B File Offset: 0x000C063B
		public unsafe string PathToComponent
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FComponentReference.__PropertyOffset_PathToComponent)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FComponentReference.__PropertyOffset_PathToComponent)), value);
			}
		}

		// Token: 0x060087A8 RID: 34728 RVA: 0x000C2450 File Offset: 0x000C0650
		public FComponentReference()
		{
		}

		// Token: 0x060087A9 RID: 34729 RVA: 0x000C2458 File Offset: 0x000C0658
		public FComponentReference(AActor OtherActor, FName ComponentProperty, string PathToComponent)
		{
			this.OtherActor = OtherActor;
			this.ComponentProperty = ComponentProperty;
			this.PathToComponent = PathToComponent;
		}

		// Token: 0x060087AA RID: 34730 RVA: 0x000C2475 File Offset: 0x000C0675
		protected override IntPtr GetUStructPtr()
		{
			return FComponentReference.StaticStruct();
		}

		// Token: 0x060087AB RID: 34731 RVA: 0x000C2481 File Offset: 0x000C0681
		[NullableContext(2)]
		public FComponentReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087AC RID: 34732 RVA: 0x000C248B File Offset: 0x000C068B
		public FComponentReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087AD RID: 34733 RVA: 0x000C2496 File Offset: 0x000C0696
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FComponentReference(Pointer, false, true);
		}

		// Token: 0x060087AE RID: 34734 RVA: 0x000C24A0 File Offset: 0x000C06A0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FComponentReference(Pointer, MemoryOwner);
		}

		// Token: 0x0400407D RID: 16509
		public const string __ObjectPath = "/Script/Engine.ComponentReference";

		// Token: 0x0400407E RID: 16510
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400407F RID: 16511
		internal static int __PropertyOffset_OtherActor;

		// Token: 0x04004080 RID: 16512
		internal static int __PropertyOffset_ComponentProperty;

		// Token: 0x04004081 RID: 16513
		internal static int __PropertyOffset_PathToComponent;
	}
}
