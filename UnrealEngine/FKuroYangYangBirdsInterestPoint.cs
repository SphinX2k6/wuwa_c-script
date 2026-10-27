using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BF4 RID: 7156
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroYangYangBirdsInterestPoint")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKuroYangYangBirdsInterestPoint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B910 RID: 112912 RVA: 0x0028944A File Offset: 0x0028764A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroYangYangBirdsInterestPoint._ScriptStructPtr != 0) ? FKuroYangYangBirdsInterestPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroYangYangBirdsInterestPoint", ref FKuroYangYangBirdsInterestPoint._ScriptStructPtr);
		}

		// Token: 0x17006F02 RID: 28418
		// (get) Token: 0x0601B911 RID: 112913 RVA: 0x0028946E File Offset: 0x0028766E
		// (set) Token: 0x0601B912 RID: 112914 RVA: 0x00289482 File Offset: 0x00287682
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroYangYangBirdsInterestPoint.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroYangYangBirdsInterestPoint.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17006F03 RID: 28419
		// (get) Token: 0x0601B913 RID: 112915 RVA: 0x00289497 File Offset: 0x00287697
		// (set) Token: 0x0601B914 RID: 112916 RVA: 0x002894A7 File Offset: 0x002876A7
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroYangYangBirdsInterestPoint.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroYangYangBirdsInterestPoint.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17006F04 RID: 28420
		// (get) Token: 0x0601B915 RID: 112917 RVA: 0x002894B8 File Offset: 0x002876B8
		// (set) Token: 0x0601B916 RID: 112918 RVA: 0x002894C8 File Offset: 0x002876C8
		public unsafe float Attraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroYangYangBirdsInterestPoint.__PropertyOffset_Attraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroYangYangBirdsInterestPoint.__PropertyOffset_Attraction) = value;
			}
		}

		// Token: 0x0601B917 RID: 112919 RVA: 0x002894D9 File Offset: 0x002876D9
		public FKuroYangYangBirdsInterestPoint()
		{
		}

		// Token: 0x0601B918 RID: 112920 RVA: 0x002894E1 File Offset: 0x002876E1
		public FKuroYangYangBirdsInterestPoint(FVector Location, float Radius, float Attraction)
		{
			this.Location = Location;
			this.Radius = Radius;
			this.Attraction = Attraction;
		}

		// Token: 0x0601B919 RID: 112921 RVA: 0x002894FE File Offset: 0x002876FE
		protected override IntPtr GetUStructPtr()
		{
			return FKuroYangYangBirdsInterestPoint.StaticStruct();
		}

		// Token: 0x0601B91A RID: 112922 RVA: 0x0028950A File Offset: 0x0028770A
		[NullableContext(2)]
		public FKuroYangYangBirdsInterestPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B91B RID: 112923 RVA: 0x00289514 File Offset: 0x00287714
		public FKuroYangYangBirdsInterestPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B91C RID: 112924 RVA: 0x0028951F File Offset: 0x0028771F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroYangYangBirdsInterestPoint(Pointer, false, true);
		}

		// Token: 0x0601B91D RID: 112925 RVA: 0x00289529 File Offset: 0x00287729
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroYangYangBirdsInterestPoint(Pointer, MemoryOwner);
		}

		// Token: 0x0400ED3C RID: 60732
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroYangYangBirdsInterestPoint";

		// Token: 0x0400ED3D RID: 60733
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ED3E RID: 60734
		internal static int __PropertyOffset_Location;

		// Token: 0x0400ED3F RID: 60735
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400ED40 RID: 60736
		internal static int __PropertyOffset_Attraction;
	}
}
