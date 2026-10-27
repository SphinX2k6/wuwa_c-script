using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015D3 RID: 5587
	[UnrealObjectPath("/Script/KawaiiPhysics.KawaiiDebugDrawSphere")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FKawaiiDebugDrawSphere : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014244 RID: 82500 RVA: 0x001D9586 File Offset: 0x001D7786
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKawaiiDebugDrawSphere._ScriptStructPtr != 0) ? FKawaiiDebugDrawSphere._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.KawaiiDebugDrawSphere", ref FKawaiiDebugDrawSphere._ScriptStructPtr);
		}

		// Token: 0x17004EF7 RID: 20215
		// (get) Token: 0x06014245 RID: 82501 RVA: 0x001D95AA File Offset: 0x001D77AA
		// (set) Token: 0x06014246 RID: 82502 RVA: 0x001D95BE File Offset: 0x001D77BE
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiDebugDrawSphere.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiDebugDrawSphere.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17004EF8 RID: 20216
		// (get) Token: 0x06014247 RID: 82503 RVA: 0x001D95D3 File Offset: 0x001D77D3
		// (set) Token: 0x06014248 RID: 82504 RVA: 0x001D95E3 File Offset: 0x001D77E3
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiDebugDrawSphere.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiDebugDrawSphere.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17004EF9 RID: 20217
		// (get) Token: 0x06014249 RID: 82505 RVA: 0x001D95F4 File Offset: 0x001D77F4
		// (set) Token: 0x0601424A RID: 82506 RVA: 0x001D9604 File Offset: 0x001D7804
		public unsafe bool bCollided
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiDebugDrawSphere.__PropertyOffset_bCollided) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiDebugDrawSphere.__PropertyOffset_bCollided) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EFA RID: 20218
		// (get) Token: 0x0601424B RID: 82507 RVA: 0x001D9615 File Offset: 0x001D7815
		// (set) Token: 0x0601424C RID: 82508 RVA: 0x001D9629 File Offset: 0x001D7829
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiDebugDrawSphere.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiDebugDrawSphere.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x0601424D RID: 82509 RVA: 0x001D963E File Offset: 0x001D783E
		public FKawaiiDebugDrawSphere()
		{
		}

		// Token: 0x0601424E RID: 82510 RVA: 0x001D9646 File Offset: 0x001D7846
		public FKawaiiDebugDrawSphere(FVector Center, float Radius, bool bCollided, FLinearColor Color)
		{
			this.Center = Center;
			this.Radius = Radius;
			this.bCollided = bCollided;
			this.Color = Color;
		}

		// Token: 0x0601424F RID: 82511 RVA: 0x001D966B File Offset: 0x001D786B
		protected override IntPtr GetUStructPtr()
		{
			return FKawaiiDebugDrawSphere.StaticStruct();
		}

		// Token: 0x06014250 RID: 82512 RVA: 0x001D9677 File Offset: 0x001D7877
		[NullableContext(2)]
		public FKawaiiDebugDrawSphere(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014251 RID: 82513 RVA: 0x001D9681 File Offset: 0x001D7881
		public FKawaiiDebugDrawSphere(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014252 RID: 82514 RVA: 0x001D968C File Offset: 0x001D788C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKawaiiDebugDrawSphere(Pointer, false, true);
		}

		// Token: 0x06014253 RID: 82515 RVA: 0x001D9696 File Offset: 0x001D7896
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKawaiiDebugDrawSphere(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF49 RID: 44873
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KawaiiPhysics.KawaiiDebugDrawSphere";

		// Token: 0x0400AF4A RID: 44874
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF4B RID: 44875
		internal static int __PropertyOffset_Center;

		// Token: 0x0400AF4C RID: 44876
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400AF4D RID: 44877
		internal static int __PropertyOffset_bCollided;

		// Token: 0x0400AF4E RID: 44878
		internal static int __PropertyOffset_Color;
	}
}
