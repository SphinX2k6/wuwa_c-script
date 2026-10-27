using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CD9 RID: 3289
	[UnrealObjectPath("/Script/Engine.KSphereElem")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FKSphereElem : FKShapeElem, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AE57 RID: 44631 RVA: 0x000F7491 File Offset: 0x000F5691
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSphereElem._ScriptStructPtr != 0) ? FKSphereElem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KSphereElem", ref FKSphereElem._ScriptStructPtr);
		}

		// Token: 0x17002761 RID: 10081
		// (get) Token: 0x0600AE58 RID: 44632 RVA: 0x000F74B5 File Offset: 0x000F56B5
		// (set) Token: 0x0600AE59 RID: 44633 RVA: 0x000F74C9 File Offset: 0x000F56C9
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSphereElem.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSphereElem.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17002762 RID: 10082
		// (get) Token: 0x0600AE5A RID: 44634 RVA: 0x000F74DE File Offset: 0x000F56DE
		// (set) Token: 0x0600AE5B RID: 44635 RVA: 0x000F74EE File Offset: 0x000F56EE
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSphereElem.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSphereElem.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x0600AE5C RID: 44636 RVA: 0x000F74FF File Offset: 0x000F56FF
		public FKSphereElem()
		{
		}

		// Token: 0x0600AE5D RID: 44637 RVA: 0x000F7507 File Offset: 0x000F5707
		public FKSphereElem(FMatrix TM_DEPRECATED, FVector Center, float Radius, float RestOffset, bool bIsGenerated, FName Name, bool bContributeToMass, TEnumAsByte<ECollisionEnabled> CollisionEnabled)
		{
			this.Center = Center;
			this.Radius = Radius;
			base.RestOffset = RestOffset;
			base.Name = Name;
			base.bContributeToMass = bContributeToMass;
			base.CollisionEnabled = CollisionEnabled;
		}

		// Token: 0x0600AE5E RID: 44638 RVA: 0x000F753D File Offset: 0x000F573D
		protected override IntPtr GetUStructPtr()
		{
			return FKSphereElem.StaticStruct();
		}

		// Token: 0x0600AE5F RID: 44639 RVA: 0x000F7549 File Offset: 0x000F5749
		[NullableContext(2)]
		public FKSphereElem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AE60 RID: 44640 RVA: 0x000F7553 File Offset: 0x000F5753
		public FKSphereElem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AE61 RID: 44641 RVA: 0x000F755E File Offset: 0x000F575E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSphereElem(Pointer, false, true);
		}

		// Token: 0x0600AE62 RID: 44642 RVA: 0x000F7568 File Offset: 0x000F5768
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSphereElem(Pointer, MemoryOwner);
		}

		// Token: 0x04005B5C RID: 23388
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KSphereElem";

		// Token: 0x04005B5D RID: 23389
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005B5E RID: 23390
		internal static int __PropertyOffset_Center;

		// Token: 0x04005B5F RID: 23391
		internal static int __PropertyOffset_Radius;
	}
}
