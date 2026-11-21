using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200071A RID: 1818
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIRaycastRangeComponent")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UUIRaycastRangeComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009C7C RID: 40060 RVA: 0x000E99DF File Offset: 0x000E7BDF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIRaycastRangeComponent._ClassPtr;
		}

		// Token: 0x06009C7D RID: 40061 RVA: 0x000E99EC File Offset: 0x000E7BEC
		public UUIRaycastRangeComponent() : this(BuiltinUtils.AllocNativeUObject(UUIRaycastRangeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009C7E RID: 40062 RVA: 0x000E9A14 File Offset: 0x000E7C14
		public UUIRaycastRangeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIRaycastRangeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x06009C7F RID: 40063 RVA: 0x000E9A47 File Offset: 0x000E7C47
		// (set) Token: 0x06009C80 RID: 40064 RVA: 0x000E9A57 File Offset: 0x000E7C57
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

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x06009C81 RID: 40065 RVA: 0x000E9A68 File Offset: 0x000E7C68
		// (set) Token: 0x06009C82 RID: 40066 RVA: 0x000E9A78 File Offset: 0x000E7C78
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

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06009C83 RID: 40067 RVA: 0x000E9A8C File Offset: 0x000E7C8C
		// (set) Token: 0x06009C84 RID: 40068 RVA: 0x000E9AC5 File Offset: 0x000E7CC5
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

		// Token: 0x06009C85 RID: 40069 RVA: 0x000E9AD3 File Offset: 0x000E7CD3
		[NullableContext(2)]
		public void SetVertsData(ULGUIVertsData InVertsData)
		{
			UUIRaycastRangeComponent.__SetVertsData_Internal(base.NativePtr, (InVertsData != null) ? InVertsData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009C86 RID: 40070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertsData_Internal(IntPtr @this, IntPtr InVertsData);

		// Token: 0x06009C87 RID: 40071 RVA: 0x000E9AF0 File Offset: 0x000E7CF0
		static UUIRaycastRangeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIRaycastRangeComponent");
		}

		// Token: 0x06009C88 RID: 40072 RVA: 0x000E9AFE File Offset: 0x000E7CFE
		protected UUIRaycastRangeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004373 RID: 17267
		public new const string __ObjectPath = "/Script/LGUI.UIRaycastRangeComponent";

		// Token: 0x04004374 RID: 17268
		private static IntPtr _ClassPtr;

		// Token: 0x04004375 RID: 17269
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004376 RID: 17270
		internal static int __PropertyOffset_PointSize;

		// Token: 0x04004377 RID: 17271
		internal static int __PropertyOffset_DragDistance;

		// Token: 0x04004378 RID: 17272
		internal static int __PropertyOffset_Points;

		// Token: 0x04004379 RID: 17273
		[Nullable(2)]
		private TArray<FVector2D> _Points;
	}
}
