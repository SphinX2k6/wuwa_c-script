using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018F2 RID: 6386
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlaySplineCircularClusterConfig")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FKuroLevelPlaySplineCircularClusterConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017AE7 RID: 96999 RVA: 0x0022B456 File Offset: 0x00229656
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelPlaySplineCircularClusterConfig._ScriptStructPtr != 0) ? FKuroLevelPlaySplineCircularClusterConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroLevelPlaySplineCircularClusterConfig", ref FKuroLevelPlaySplineCircularClusterConfig._ScriptStructPtr);
		}

		// Token: 0x17005F69 RID: 24425
		// (get) Token: 0x06017AE8 RID: 97000 RVA: 0x0022B47A File Offset: 0x0022967A
		// (set) Token: 0x06017AE9 RID: 97001 RVA: 0x0022B48A File Offset: 0x0022968A
		public unsafe EKuroLevelPlaySplineCircularClusterSampleMethod SampleMethod
		{
			get
			{
				return (EKuroLevelPlaySplineCircularClusterSampleMethod)(*(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_SampleMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_SampleMethod) = (byte)value;
			}
		}

		// Token: 0x17005F6A RID: 24426
		// (get) Token: 0x06017AEA RID: 97002 RVA: 0x0022B49B File Offset: 0x0022969B
		// (set) Token: 0x06017AEB RID: 97003 RVA: 0x0022B4AB File Offset: 0x002296AB
		public unsafe float Spacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_Spacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_Spacing) = value;
			}
		}

		// Token: 0x17005F6B RID: 24427
		// (get) Token: 0x06017AEC RID: 97004 RVA: 0x0022B4BC File Offset: 0x002296BC
		// (set) Token: 0x06017AED RID: 97005 RVA: 0x0022B4CC File Offset: 0x002296CC
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17005F6C RID: 24428
		// (get) Token: 0x06017AEE RID: 97006 RVA: 0x0022B4DD File Offset: 0x002296DD
		// (set) Token: 0x06017AEF RID: 97007 RVA: 0x0022B4ED File Offset: 0x002296ED
		public unsafe float MinFoliageIntersectionDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_MinFoliageIntersectionDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_MinFoliageIntersectionDepth) = value;
			}
		}

		// Token: 0x17005F6D RID: 24429
		// (get) Token: 0x06017AF0 RID: 97008 RVA: 0x0022B4FE File Offset: 0x002296FE
		// (set) Token: 0x06017AF1 RID: 97009 RVA: 0x0022B50E File Offset: 0x0022970E
		public unsafe int ParallelCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_ParallelCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_ParallelCount) = value;
			}
		}

		// Token: 0x17005F6E RID: 24430
		// (get) Token: 0x06017AF2 RID: 97010 RVA: 0x0022B51F File Offset: 0x0022971F
		// (set) Token: 0x06017AF3 RID: 97011 RVA: 0x0022B52F File Offset: 0x0022972F
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_Width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_Width) = value;
			}
		}

		// Token: 0x17005F6F RID: 24431
		// (get) Token: 0x06017AF4 RID: 97012 RVA: 0x0022B540 File Offset: 0x00229740
		// (set) Token: 0x06017AF5 RID: 97013 RVA: 0x0022B550 File Offset: 0x00229750
		public unsafe bool bDebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_bDebugDraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlaySplineCircularClusterConfig.__PropertyOffset_bDebugDraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x06017AF6 RID: 97014 RVA: 0x0022B561 File Offset: 0x00229761
		public FKuroLevelPlaySplineCircularClusterConfig()
		{
		}

		// Token: 0x06017AF7 RID: 97015 RVA: 0x0022B569 File Offset: 0x00229769
		public FKuroLevelPlaySplineCircularClusterConfig(EKuroLevelPlaySplineCircularClusterSampleMethod SampleMethod, float Spacing, float Radius, float MinFoliageIntersectionDepth, int ParallelCount, float Width, bool bDebugDraw)
		{
			this.SampleMethod = SampleMethod;
			this.Spacing = Spacing;
			this.Radius = Radius;
			this.MinFoliageIntersectionDepth = MinFoliageIntersectionDepth;
			this.ParallelCount = ParallelCount;
			this.Width = Width;
			this.bDebugDraw = bDebugDraw;
		}

		// Token: 0x06017AF8 RID: 97016 RVA: 0x0022B5A6 File Offset: 0x002297A6
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelPlaySplineCircularClusterConfig.StaticStruct();
		}

		// Token: 0x06017AF9 RID: 97017 RVA: 0x0022B5B2 File Offset: 0x002297B2
		[NullableContext(2)]
		public FKuroLevelPlaySplineCircularClusterConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017AFA RID: 97018 RVA: 0x0022B5BC File Offset: 0x002297BC
		public FKuroLevelPlaySplineCircularClusterConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017AFB RID: 97019 RVA: 0x0022B5C7 File Offset: 0x002297C7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelPlaySplineCircularClusterConfig(Pointer, false, true);
		}

		// Token: 0x06017AFC RID: 97020 RVA: 0x0022B5D1 File Offset: 0x002297D1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelPlaySplineCircularClusterConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400CDC2 RID: 52674
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlaySplineCircularClusterConfig";

		// Token: 0x0400CDC3 RID: 52675
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CDC4 RID: 52676
		internal static int __PropertyOffset_SampleMethod;

		// Token: 0x0400CDC5 RID: 52677
		internal static int __PropertyOffset_Spacing;

		// Token: 0x0400CDC6 RID: 52678
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400CDC7 RID: 52679
		internal static int __PropertyOffset_MinFoliageIntersectionDepth;

		// Token: 0x0400CDC8 RID: 52680
		internal static int __PropertyOffset_ParallelCount;

		// Token: 0x0400CDC9 RID: 52681
		internal static int __PropertyOffset_Width;

		// Token: 0x0400CDCA RID: 52682
		internal static int __PropertyOffset_bDebugDraw;
	}
}
