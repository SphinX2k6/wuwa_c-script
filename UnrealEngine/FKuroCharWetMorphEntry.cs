using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001ACB RID: 6859
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetMorphEntry")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FKuroCharWetMorphEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060197E4 RID: 104420 RVA: 0x0025AAF3 File Offset: 0x00258CF3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCharWetMorphEntry._ScriptStructPtr != 0) ? FKuroCharWetMorphEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetMorphEntry", ref FKuroCharWetMorphEntry._ScriptStructPtr);
		}

		// Token: 0x170065A4 RID: 26020
		// (get) Token: 0x060197E5 RID: 104421 RVA: 0x0025AB17 File Offset: 0x00258D17
		// (set) Token: 0x060197E6 RID: 104422 RVA: 0x0025AB2B File Offset: 0x00258D2B
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharWetMorphEntry.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharWetMorphEntry.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x060197E7 RID: 104423 RVA: 0x0025AB40 File Offset: 0x00258D40
		public FKuroCharWetMorphEntry()
		{
		}

		// Token: 0x060197E8 RID: 104424 RVA: 0x0025AB48 File Offset: 0x00258D48
		public FKuroCharWetMorphEntry(FName Name)
		{
			this.Name = Name;
		}

		// Token: 0x060197E9 RID: 104425 RVA: 0x0025AB57 File Offset: 0x00258D57
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCharWetMorphEntry.StaticStruct();
		}

		// Token: 0x060197EA RID: 104426 RVA: 0x0025AB63 File Offset: 0x00258D63
		[NullableContext(2)]
		public FKuroCharWetMorphEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060197EB RID: 104427 RVA: 0x0025AB6D File Offset: 0x00258D6D
		public FKuroCharWetMorphEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060197EC RID: 104428 RVA: 0x0025AB78 File Offset: 0x00258D78
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCharWetMorphEntry(Pointer, false, true);
		}

		// Token: 0x060197ED RID: 104429 RVA: 0x0025AB82 File Offset: 0x00258D82
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCharWetMorphEntry(Pointer, MemoryOwner);
		}

		// Token: 0x0400DDFB RID: 56827
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetMorphEntry";

		// Token: 0x0400DDFC RID: 56828
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DDFD RID: 56829
		internal static int __PropertyOffset_Name;
	}
}
