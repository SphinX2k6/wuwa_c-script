using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CD8 RID: 3288
	[UnrealObjectPath("/Script/Engine.KShapeElem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKShapeElem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AE47 RID: 44615 RVA: 0x000F734F File Offset: 0x000F554F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKShapeElem._ScriptStructPtr != 0) ? FKShapeElem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KShapeElem", ref FKShapeElem._ScriptStructPtr);
		}

		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x0600AE48 RID: 44616 RVA: 0x000F7373 File Offset: 0x000F5573
		// (set) Token: 0x0600AE49 RID: 44617 RVA: 0x000F7383 File Offset: 0x000F5583
		public unsafe float RestOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKShapeElem.__PropertyOffset_RestOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKShapeElem.__PropertyOffset_RestOffset) = value;
			}
		}

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x0600AE4A RID: 44618 RVA: 0x000F7394 File Offset: 0x000F5594
		// (set) Token: 0x0600AE4B RID: 44619 RVA: 0x000F73A8 File Offset: 0x000F55A8
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKShapeElem.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKShapeElem.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x0600AE4C RID: 44620 RVA: 0x000F73BD File Offset: 0x000F55BD
		// (set) Token: 0x0600AE4D RID: 44621 RVA: 0x000F73D6 File Offset: 0x000F55D6
		public unsafe bool bContributeToMass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKShapeElem.__PropertyOffset_bContributeToMass) & FKShapeElem.__PropertyMask_bContributeToMass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKShapeElem.__PropertyOffset_bContributeToMass) = ((*(base.NativePtr + (IntPtr)FKShapeElem.__PropertyOffset_bContributeToMass) & ~FKShapeElem.__PropertyMask_bContributeToMass) | (value ? FKShapeElem.__PropertyMask_bContributeToMass : 0));
			}
		}

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x0600AE4E RID: 44622 RVA: 0x000F7406 File Offset: 0x000F5606
		// (set) Token: 0x0600AE4F RID: 44623 RVA: 0x000F741A File Offset: 0x000F561A
		public unsafe TEnumAsByte<ECollisionEnabled> CollisionEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKShapeElem.__PropertyOffset_CollisionEnabled);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKShapeElem.__PropertyOffset_CollisionEnabled) = value;
			}
		}

		// Token: 0x0600AE50 RID: 44624 RVA: 0x000F742F File Offset: 0x000F562F
		public FKShapeElem()
		{
		}

		// Token: 0x0600AE51 RID: 44625 RVA: 0x000F7437 File Offset: 0x000F5637
		public FKShapeElem(float RestOffset, bool bIsGenerated, FName Name, bool bContributeToMass, TEnumAsByte<ECollisionEnabled> CollisionEnabled)
		{
			this.RestOffset = RestOffset;
			this.Name = Name;
			this.bContributeToMass = bContributeToMass;
			this.CollisionEnabled = CollisionEnabled;
		}

		// Token: 0x0600AE52 RID: 44626 RVA: 0x000F745D File Offset: 0x000F565D
		protected override IntPtr GetUStructPtr()
		{
			return FKShapeElem.StaticStruct();
		}

		// Token: 0x0600AE53 RID: 44627 RVA: 0x000F7469 File Offset: 0x000F5669
		[NullableContext(2)]
		public FKShapeElem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AE54 RID: 44628 RVA: 0x000F7473 File Offset: 0x000F5673
		public FKShapeElem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AE55 RID: 44629 RVA: 0x000F747E File Offset: 0x000F567E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKShapeElem(Pointer, false, true);
		}

		// Token: 0x0600AE56 RID: 44630 RVA: 0x000F7488 File Offset: 0x000F5688
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKShapeElem(Pointer, MemoryOwner);
		}

		// Token: 0x04005B55 RID: 23381
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KShapeElem";

		// Token: 0x04005B56 RID: 23382
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005B57 RID: 23383
		internal static int __PropertyOffset_RestOffset;

		// Token: 0x04005B58 RID: 23384
		internal static int __PropertyOffset_Name;

		// Token: 0x04005B59 RID: 23385
		internal static int __PropertyOffset_bContributeToMass;

		// Token: 0x04005B5A RID: 23386
		internal static byte __PropertyMask_bContributeToMass;

		// Token: 0x04005B5B RID: 23387
		internal static int __PropertyOffset_CollisionEnabled;
	}
}
