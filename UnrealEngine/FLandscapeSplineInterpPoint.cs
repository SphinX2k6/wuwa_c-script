using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F8B RID: 8075
	[UnrealObjectPath("/Script/Landscape.LandscapeSplineInterpPoint")]
	[UnrealStructLayout(112, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FLandscapeSplineInterpPoint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EAA3 RID: 125603 RVA: 0x002D94FC File Offset: 0x002D76FC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeSplineInterpPoint._ScriptStructPtr != 0) ? FLandscapeSplineInterpPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeSplineInterpPoint", ref FLandscapeSplineInterpPoint._ScriptStructPtr);
		}

		// Token: 0x17007A22 RID: 31266
		// (get) Token: 0x0601EAA4 RID: 125604 RVA: 0x002D9520 File Offset: 0x002D7720
		// (set) Token: 0x0601EAA5 RID: 125605 RVA: 0x002D9534 File Offset: 0x002D7734
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17007A23 RID: 31267
		// (get) Token: 0x0601EAA6 RID: 125606 RVA: 0x002D9549 File Offset: 0x002D7749
		// (set) Token: 0x0601EAA7 RID: 125607 RVA: 0x002D955D File Offset: 0x002D775D
		public unsafe FVector Left
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_Left);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_Left) = value;
			}
		}

		// Token: 0x17007A24 RID: 31268
		// (get) Token: 0x0601EAA8 RID: 125608 RVA: 0x002D9572 File Offset: 0x002D7772
		// (set) Token: 0x0601EAA9 RID: 125609 RVA: 0x002D9586 File Offset: 0x002D7786
		public unsafe FVector Right
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_Right);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_Right) = value;
			}
		}

		// Token: 0x17007A25 RID: 31269
		// (get) Token: 0x0601EAAA RID: 125610 RVA: 0x002D959B File Offset: 0x002D779B
		// (set) Token: 0x0601EAAB RID: 125611 RVA: 0x002D95AF File Offset: 0x002D77AF
		public unsafe FVector FalloffLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_FalloffLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_FalloffLeft) = value;
			}
		}

		// Token: 0x17007A26 RID: 31270
		// (get) Token: 0x0601EAAC RID: 125612 RVA: 0x002D95C4 File Offset: 0x002D77C4
		// (set) Token: 0x0601EAAD RID: 125613 RVA: 0x002D95D8 File Offset: 0x002D77D8
		public unsafe FVector FalloffRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_FalloffRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_FalloffRight) = value;
			}
		}

		// Token: 0x17007A27 RID: 31271
		// (get) Token: 0x0601EAAE RID: 125614 RVA: 0x002D95ED File Offset: 0x002D77ED
		// (set) Token: 0x0601EAAF RID: 125615 RVA: 0x002D9601 File Offset: 0x002D7801
		public unsafe FVector LayerLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_LayerLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_LayerLeft) = value;
			}
		}

		// Token: 0x17007A28 RID: 31272
		// (get) Token: 0x0601EAB0 RID: 125616 RVA: 0x002D9616 File Offset: 0x002D7816
		// (set) Token: 0x0601EAB1 RID: 125617 RVA: 0x002D962A File Offset: 0x002D782A
		public unsafe FVector LayerRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_LayerRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_LayerRight) = value;
			}
		}

		// Token: 0x17007A29 RID: 31273
		// (get) Token: 0x0601EAB2 RID: 125618 RVA: 0x002D963F File Offset: 0x002D783F
		// (set) Token: 0x0601EAB3 RID: 125619 RVA: 0x002D9653 File Offset: 0x002D7853
		public unsafe FVector LayerFalloffLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_LayerFalloffLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_LayerFalloffLeft) = value;
			}
		}

		// Token: 0x17007A2A RID: 31274
		// (get) Token: 0x0601EAB4 RID: 125620 RVA: 0x002D9668 File Offset: 0x002D7868
		// (set) Token: 0x0601EAB5 RID: 125621 RVA: 0x002D967C File Offset: 0x002D787C
		public unsafe FVector LayerFalloffRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_LayerFalloffRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_LayerFalloffRight) = value;
			}
		}

		// Token: 0x17007A2B RID: 31275
		// (get) Token: 0x0601EAB6 RID: 125622 RVA: 0x002D9691 File Offset: 0x002D7891
		// (set) Token: 0x0601EAB7 RID: 125623 RVA: 0x002D96A1 File Offset: 0x002D78A1
		public unsafe float StartEndFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_StartEndFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineInterpPoint.__PropertyOffset_StartEndFalloff) = value;
			}
		}

		// Token: 0x0601EAB8 RID: 125624 RVA: 0x002D96B2 File Offset: 0x002D78B2
		public FLandscapeSplineInterpPoint()
		{
		}

		// Token: 0x0601EAB9 RID: 125625 RVA: 0x002D96BC File Offset: 0x002D78BC
		public FLandscapeSplineInterpPoint(FVector Center, FVector Left, FVector Right, FVector FalloffLeft, FVector FalloffRight, FVector LayerLeft, FVector LayerRight, FVector LayerFalloffLeft, FVector LayerFalloffRight, float StartEndFalloff)
		{
			this.Center = Center;
			this.Left = Left;
			this.Right = Right;
			this.FalloffLeft = FalloffLeft;
			this.FalloffRight = FalloffRight;
			this.LayerLeft = LayerLeft;
			this.LayerRight = LayerRight;
			this.LayerFalloffLeft = LayerFalloffLeft;
			this.LayerFalloffRight = LayerFalloffRight;
			this.StartEndFalloff = StartEndFalloff;
		}

		// Token: 0x0601EABA RID: 125626 RVA: 0x002D971C File Offset: 0x002D791C
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeSplineInterpPoint.StaticStruct();
		}

		// Token: 0x0601EABB RID: 125627 RVA: 0x002D9728 File Offset: 0x002D7928
		[NullableContext(2)]
		public FLandscapeSplineInterpPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EABC RID: 125628 RVA: 0x002D9732 File Offset: 0x002D7932
		public FLandscapeSplineInterpPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EABD RID: 125629 RVA: 0x002D973D File Offset: 0x002D793D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeSplineInterpPoint(Pointer, false, true);
		}

		// Token: 0x0601EABE RID: 125630 RVA: 0x002D9747 File Offset: 0x002D7947
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeSplineInterpPoint(Pointer, MemoryOwner);
		}

		// Token: 0x0401093A RID: 67898
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.LandscapeSplineInterpPoint";

		// Token: 0x0401093B RID: 67899
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401093C RID: 67900
		internal static int __PropertyOffset_Center;

		// Token: 0x0401093D RID: 67901
		internal static int __PropertyOffset_Left;

		// Token: 0x0401093E RID: 67902
		internal static int __PropertyOffset_Right;

		// Token: 0x0401093F RID: 67903
		internal static int __PropertyOffset_FalloffLeft;

		// Token: 0x04010940 RID: 67904
		internal static int __PropertyOffset_FalloffRight;

		// Token: 0x04010941 RID: 67905
		internal static int __PropertyOffset_LayerLeft;

		// Token: 0x04010942 RID: 67906
		internal static int __PropertyOffset_LayerRight;

		// Token: 0x04010943 RID: 67907
		internal static int __PropertyOffset_LayerFalloffLeft;

		// Token: 0x04010944 RID: 67908
		internal static int __PropertyOffset_LayerFalloffRight;

		// Token: 0x04010945 RID: 67909
		internal static int __PropertyOffset_StartEndFalloff;
	}
}
