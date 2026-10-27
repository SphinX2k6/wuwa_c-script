using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CDA RID: 3290
	[UnrealObjectPath("/Script/Engine.KSphylElem")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FKSphylElem : FKShapeElem, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AE63 RID: 44643 RVA: 0x000F7571 File Offset: 0x000F5771
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSphylElem._ScriptStructPtr != 0) ? FKSphylElem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KSphylElem", ref FKSphylElem._ScriptStructPtr);
		}

		// Token: 0x17002763 RID: 10083
		// (get) Token: 0x0600AE64 RID: 44644 RVA: 0x000F7595 File Offset: 0x000F5795
		// (set) Token: 0x0600AE65 RID: 44645 RVA: 0x000F75A9 File Offset: 0x000F57A9
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSphylElem.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSphylElem.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17002764 RID: 10084
		// (get) Token: 0x0600AE66 RID: 44646 RVA: 0x000F75BE File Offset: 0x000F57BE
		// (set) Token: 0x0600AE67 RID: 44647 RVA: 0x000F75D2 File Offset: 0x000F57D2
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSphylElem.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSphylElem.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17002765 RID: 10085
		// (get) Token: 0x0600AE68 RID: 44648 RVA: 0x000F75E7 File Offset: 0x000F57E7
		// (set) Token: 0x0600AE69 RID: 44649 RVA: 0x000F75F7 File Offset: 0x000F57F7
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSphylElem.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSphylElem.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17002766 RID: 10086
		// (get) Token: 0x0600AE6A RID: 44650 RVA: 0x000F7608 File Offset: 0x000F5808
		// (set) Token: 0x0600AE6B RID: 44651 RVA: 0x000F7618 File Offset: 0x000F5818
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSphylElem.__PropertyOffset_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSphylElem.__PropertyOffset_Length) = value;
			}
		}

		// Token: 0x0600AE6C RID: 44652 RVA: 0x000F7629 File Offset: 0x000F5829
		public FKSphylElem()
		{
		}

		// Token: 0x0600AE6D RID: 44653 RVA: 0x000F7634 File Offset: 0x000F5834
		public FKSphylElem(FMatrix TM_DEPRECATED, FQuat Orientation_DEPRECATED, FVector Center, FRotator Rotation, float Radius, float Length, float RestOffset, bool bIsGenerated, FName Name, bool bContributeToMass, TEnumAsByte<ECollisionEnabled> CollisionEnabled)
		{
			this.Center = Center;
			this.Rotation = Rotation;
			this.Radius = Radius;
			this.Length = Length;
			base.RestOffset = RestOffset;
			base.Name = Name;
			base.bContributeToMass = bContributeToMass;
			base.CollisionEnabled = CollisionEnabled;
		}

		// Token: 0x0600AE6E RID: 44654 RVA: 0x000F7686 File Offset: 0x000F5886
		protected override IntPtr GetUStructPtr()
		{
			return FKSphylElem.StaticStruct();
		}

		// Token: 0x0600AE6F RID: 44655 RVA: 0x000F7692 File Offset: 0x000F5892
		[NullableContext(2)]
		public FKSphylElem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AE70 RID: 44656 RVA: 0x000F769C File Offset: 0x000F589C
		public FKSphylElem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AE71 RID: 44657 RVA: 0x000F76A7 File Offset: 0x000F58A7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSphylElem(Pointer, false, true);
		}

		// Token: 0x0600AE72 RID: 44658 RVA: 0x000F76B1 File Offset: 0x000F58B1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSphylElem(Pointer, MemoryOwner);
		}

		// Token: 0x04005B60 RID: 23392
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KSphylElem";

		// Token: 0x04005B61 RID: 23393
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005B62 RID: 23394
		internal static int __PropertyOffset_Center;

		// Token: 0x04005B63 RID: 23395
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04005B64 RID: 23396
		internal static int __PropertyOffset_Radius;

		// Token: 0x04005B65 RID: 23397
		internal static int __PropertyOffset_Length;
	}
}
