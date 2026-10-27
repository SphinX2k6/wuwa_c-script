using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BF3 RID: 7155
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroYangYangBirdsFrightenPoint")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKuroYangYangBirdsFrightenPoint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B902 RID: 112898 RVA: 0x00289362 File Offset: 0x00287562
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroYangYangBirdsFrightenPoint._ScriptStructPtr != 0) ? FKuroYangYangBirdsFrightenPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroYangYangBirdsFrightenPoint", ref FKuroYangYangBirdsFrightenPoint._ScriptStructPtr);
		}

		// Token: 0x17006EFF RID: 28415
		// (get) Token: 0x0601B903 RID: 112899 RVA: 0x00289386 File Offset: 0x00287586
		// (set) Token: 0x0601B904 RID: 112900 RVA: 0x0028939A File Offset: 0x0028759A
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroYangYangBirdsFrightenPoint.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroYangYangBirdsFrightenPoint.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17006F00 RID: 28416
		// (get) Token: 0x0601B905 RID: 112901 RVA: 0x002893AF File Offset: 0x002875AF
		// (set) Token: 0x0601B906 RID: 112902 RVA: 0x002893BF File Offset: 0x002875BF
		public unsafe float Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroYangYangBirdsFrightenPoint.__PropertyOffset_Strength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroYangYangBirdsFrightenPoint.__PropertyOffset_Strength) = value;
			}
		}

		// Token: 0x17006F01 RID: 28417
		// (get) Token: 0x0601B907 RID: 112903 RVA: 0x002893D0 File Offset: 0x002875D0
		// (set) Token: 0x0601B908 RID: 112904 RVA: 0x002893E0 File Offset: 0x002875E0
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroYangYangBirdsFrightenPoint.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroYangYangBirdsFrightenPoint.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x0601B909 RID: 112905 RVA: 0x002893F1 File Offset: 0x002875F1
		public FKuroYangYangBirdsFrightenPoint()
		{
		}

		// Token: 0x0601B90A RID: 112906 RVA: 0x002893F9 File Offset: 0x002875F9
		public FKuroYangYangBirdsFrightenPoint(FVector Location, float Strength, float Radius)
		{
			this.Location = Location;
			this.Strength = Strength;
			this.Radius = Radius;
		}

		// Token: 0x0601B90B RID: 112907 RVA: 0x00289416 File Offset: 0x00287616
		protected override IntPtr GetUStructPtr()
		{
			return FKuroYangYangBirdsFrightenPoint.StaticStruct();
		}

		// Token: 0x0601B90C RID: 112908 RVA: 0x00289422 File Offset: 0x00287622
		[NullableContext(2)]
		public FKuroYangYangBirdsFrightenPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B90D RID: 112909 RVA: 0x0028942C File Offset: 0x0028762C
		public FKuroYangYangBirdsFrightenPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B90E RID: 112910 RVA: 0x00289437 File Offset: 0x00287637
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroYangYangBirdsFrightenPoint(Pointer, false, true);
		}

		// Token: 0x0601B90F RID: 112911 RVA: 0x00289441 File Offset: 0x00287641
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroYangYangBirdsFrightenPoint(Pointer, MemoryOwner);
		}

		// Token: 0x0400ED37 RID: 60727
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroYangYangBirdsFrightenPoint";

		// Token: 0x0400ED38 RID: 60728
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ED39 RID: 60729
		internal static int __PropertyOffset_Location;

		// Token: 0x0400ED3A RID: 60730
		internal static int __PropertyOffset_Strength;

		// Token: 0x0400ED3B RID: 60731
		internal static int __PropertyOffset_Radius;
	}
}
