using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200219B RID: 8603
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIRaycastRangeComponent")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UUIRaycastRangeComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060209FC RID: 133628 RVA: 0x0030490D File Offset: 0x00302B0D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIRaycastRangeComponent._ClassPtr;
		}

		// Token: 0x060209FD RID: 133629 RVA: 0x0030491C File Offset: 0x00302B1C
		public UUIRaycastRangeComponent() : this(BuiltinUtils.AllocNativeUObject(UUIRaycastRangeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060209FE RID: 133630 RVA: 0x00304944 File Offset: 0x00302B44
		public UUIRaycastRangeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIRaycastRangeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F84 RID: 32644
		// (get) Token: 0x060209FF RID: 133631 RVA: 0x00304977 File Offset: 0x00302B77
		// (set) Token: 0x06020A00 RID: 133632 RVA: 0x00304987 File Offset: 0x00302B87
		public unsafe float PointSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRaycastRangeComponent.__PropertyOffset_PointSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRaycastRangeComponent.__PropertyOffset_PointSize) = value;
			}
		}

		// Token: 0x17007F85 RID: 32645
		// (get) Token: 0x06020A01 RID: 133633 RVA: 0x00304998 File Offset: 0x00302B98
		// (set) Token: 0x06020A02 RID: 133634 RVA: 0x003049A8 File Offset: 0x00302BA8
		public unsafe int DragDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRaycastRangeComponent.__PropertyOffset_DragDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRaycastRangeComponent.__PropertyOffset_DragDistance) = value;
			}
		}

		// Token: 0x17007F86 RID: 32646
		// (get) Token: 0x06020A03 RID: 133635 RVA: 0x003049BC File Offset: 0x00302BBC
		// (set) Token: 0x06020A04 RID: 133636 RVA: 0x003049F5 File Offset: 0x00302BF5
		public TArray<FVector2D> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FVector2D>(base.NativePtr + (IntPtr)UUIRaycastRangeComponent.__PropertyOffset_Points, this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x06020A05 RID: 133637 RVA: 0x00304A03 File Offset: 0x00302C03
		[NullableContext(2)]
		public void SetVertsData(ULGUIVertsData InVertsData)
		{
			UUIRaycastRangeComponent.__SetVertsData_Internal(base.NativePtr, (InVertsData != null) ? InVertsData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020A06 RID: 133638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertsData_Internal(IntPtr @this, IntPtr InVertsData);

		// Token: 0x06020A07 RID: 133639 RVA: 0x00304A20 File Offset: 0x00302C20
		static UUIRaycastRangeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIRaycastRangeComponent");
		}

		// Token: 0x06020A08 RID: 133640 RVA: 0x00304A2E File Offset: 0x00302C2E
		protected UUIRaycastRangeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011757 RID: 71511
		public new const string __ObjectPath = "/Script/LGUI.UIRaycastRangeComponent";

		// Token: 0x04011758 RID: 71512
		private static IntPtr _ClassPtr;

		// Token: 0x04011759 RID: 71513
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401175A RID: 71514
		internal static int __PropertyOffset_PointSize;

		// Token: 0x0401175B RID: 71515
		internal static int __PropertyOffset_DragDistance;

		// Token: 0x0401175C RID: 71516
		internal static int __PropertyOffset_Points;

		// Token: 0x0401175D RID: 71517
		[Nullable(2)]
		private TArray<FVector2D> _Points;
	}
}
