using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027CA RID: 10186
	[UnrealObjectPath("/Script/SimplygonUObjects.PartRemoverSettings")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FPartRemoverSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025F9A RID: 155546 RVA: 0x003993E7 File Offset: 0x003975E7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPartRemoverSettings._ScriptStructPtr != 0) ? FPartRemoverSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.PartRemoverSettings", ref FPartRemoverSettings._ScriptStructPtr);
		}

		// Token: 0x17009273 RID: 37491
		// (get) Token: 0x06025F9B RID: 155547 RVA: 0x0039940B File Offset: 0x0039760B
		// (set) Token: 0x06025F9C RID: 155548 RVA: 0x0039941B File Offset: 0x0039761B
		public unsafe EPartRemoverThresholdType PartRemoverThresholdType
		{
			get
			{
				return (EPartRemoverThresholdType)(*(base.NativePtr + (IntPtr)FPartRemoverSettings.__PropertyOffset_PartRemoverThresholdType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPartRemoverSettings.__PropertyOffset_PartRemoverThresholdType) = (byte)value;
			}
		}

		// Token: 0x17009274 RID: 37492
		// (get) Token: 0x06025F9D RID: 155549 RVA: 0x0039942C File Offset: 0x0039762C
		// (set) Token: 0x06025F9E RID: 155550 RVA: 0x0039943C File Offset: 0x0039763C
		public unsafe float Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPartRemoverSettings.__PropertyOffset_Threshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPartRemoverSettings.__PropertyOffset_Threshold) = value;
			}
		}

		// Token: 0x17009275 RID: 37493
		// (get) Token: 0x06025F9F RID: 155551 RVA: 0x0039944D File Offset: 0x0039764D
		// (set) Token: 0x06025FA0 RID: 155552 RVA: 0x00399466 File Offset: 0x00397666
		public unsafe bool UseSurfaceArea
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPartRemoverSettings.__PropertyOffset_UseSurfaceArea) & FPartRemoverSettings.__PropertyMask_UseSurfaceArea) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPartRemoverSettings.__PropertyOffset_UseSurfaceArea) = ((*(base.NativePtr + (IntPtr)FPartRemoverSettings.__PropertyOffset_UseSurfaceArea) & ~FPartRemoverSettings.__PropertyMask_UseSurfaceArea) | (value ? FPartRemoverSettings.__PropertyMask_UseSurfaceArea : 0));
			}
		}

		// Token: 0x17009276 RID: 37494
		// (get) Token: 0x06025FA1 RID: 155553 RVA: 0x00399496 File Offset: 0x00397696
		// (set) Token: 0x06025FA2 RID: 155554 RVA: 0x003994AF File Offset: 0x003976AF
		public unsafe bool UseVertexLocks
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPartRemoverSettings.__PropertyOffset_UseVertexLocks) & FPartRemoverSettings.__PropertyMask_UseVertexLocks) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPartRemoverSettings.__PropertyOffset_UseVertexLocks) = ((*(base.NativePtr + (IntPtr)FPartRemoverSettings.__PropertyOffset_UseVertexLocks) & ~FPartRemoverSettings.__PropertyMask_UseVertexLocks) | (value ? FPartRemoverSettings.__PropertyMask_UseVertexLocks : 0));
			}
		}

		// Token: 0x06025FA3 RID: 155555 RVA: 0x003994DF File Offset: 0x003976DF
		public FPartRemoverSettings()
		{
		}

		// Token: 0x06025FA4 RID: 155556 RVA: 0x003994E7 File Offset: 0x003976E7
		public FPartRemoverSettings(EPartRemoverThresholdType PartRemoverThresholdType, float Threshold, bool UseSurfaceArea, bool UseVertexLocks)
		{
			this.PartRemoverThresholdType = PartRemoverThresholdType;
			this.Threshold = Threshold;
			this.UseSurfaceArea = UseSurfaceArea;
			this.UseVertexLocks = UseVertexLocks;
		}

		// Token: 0x06025FA5 RID: 155557 RVA: 0x0039950C File Offset: 0x0039770C
		protected override IntPtr GetUStructPtr()
		{
			return FPartRemoverSettings.StaticStruct();
		}

		// Token: 0x06025FA6 RID: 155558 RVA: 0x00399518 File Offset: 0x00397718
		[NullableContext(2)]
		public FPartRemoverSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025FA7 RID: 155559 RVA: 0x00399522 File Offset: 0x00397722
		public FPartRemoverSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025FA8 RID: 155560 RVA: 0x0039952D File Offset: 0x0039772D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPartRemoverSettings(Pointer, false, true);
		}

		// Token: 0x06025FA9 RID: 155561 RVA: 0x00399537 File Offset: 0x00397737
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPartRemoverSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014BA7 RID: 84903
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SimplygonUObjects.PartRemoverSettings";

		// Token: 0x04014BA8 RID: 84904
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014BA9 RID: 84905
		internal static int __PropertyOffset_PartRemoverThresholdType;

		// Token: 0x04014BAA RID: 84906
		internal static int __PropertyOffset_Threshold;

		// Token: 0x04014BAB RID: 84907
		internal static int __PropertyOffset_UseSurfaceArea;

		// Token: 0x04014BAC RID: 84908
		internal static byte __PropertyMask_UseSurfaceArea;

		// Token: 0x04014BAD RID: 84909
		internal static int __PropertyOffset_UseVertexLocks;

		// Token: 0x04014BAE RID: 84910
		internal static byte __PropertyMask_UseVertexLocks;
	}
}
