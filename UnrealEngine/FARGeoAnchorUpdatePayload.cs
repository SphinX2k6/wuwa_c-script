using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A6 RID: 934
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARGeoAnchorUpdatePayload")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FARGeoAnchorUpdatePayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060033CD RID: 13261 RVA: 0x0004F33C File Offset: 0x0004D53C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARGeoAnchorUpdatePayload._ScriptStructPtr != 0) ? FARGeoAnchorUpdatePayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARGeoAnchorUpdatePayload", ref FARGeoAnchorUpdatePayload._ScriptStructPtr);
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060033CE RID: 13262 RVA: 0x0004F360 File Offset: 0x0004D560
		// (set) Token: 0x060033CF RID: 13263 RVA: 0x0004F3A3 File Offset: 0x0004D5A3
		public FARSessionPayload SessionPayload
		{
			get
			{
				base.FastCheckIsValid();
				FARSessionPayload result;
				if ((result = this._SessionPayload) == null)
				{
					result = (this._SessionPayload = new FARSessionPayload(base.NativePtr + (IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_SessionPayload, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARSessionPayload.StaticStruct(), base.NativePtr + (IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_SessionPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060033D0 RID: 13264 RVA: 0x0004F3C4 File Offset: 0x0004D5C4
		// (set) Token: 0x060033D1 RID: 13265 RVA: 0x0004F3D8 File Offset: 0x0004D5D8
		public unsafe FTransform WorldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_WorldTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_WorldTransform) = value;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060033D2 RID: 13266 RVA: 0x0004F3ED File Offset: 0x0004D5ED
		// (set) Token: 0x060033D3 RID: 13267 RVA: 0x0004F3FD File Offset: 0x0004D5FD
		public unsafe float Longitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_Longitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_Longitude) = value;
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060033D4 RID: 13268 RVA: 0x0004F40E File Offset: 0x0004D60E
		// (set) Token: 0x060033D5 RID: 13269 RVA: 0x0004F41E File Offset: 0x0004D61E
		public unsafe float Latitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_Latitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_Latitude) = value;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060033D6 RID: 13270 RVA: 0x0004F42F File Offset: 0x0004D62F
		// (set) Token: 0x060033D7 RID: 13271 RVA: 0x0004F43F File Offset: 0x0004D63F
		public unsafe float AltitudeMeters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_AltitudeMeters);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_AltitudeMeters) = value;
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060033D8 RID: 13272 RVA: 0x0004F450 File Offset: 0x0004D650
		// (set) Token: 0x060033D9 RID: 13273 RVA: 0x0004F460 File Offset: 0x0004D660
		public unsafe EARAltitudeSource AltitudeSource
		{
			get
			{
				return (EARAltitudeSource)(*(base.NativePtr + (IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_AltitudeSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_AltitudeSource) = (byte)value;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060033DA RID: 13274 RVA: 0x0004F471 File Offset: 0x0004D671
		// (set) Token: 0x060033DB RID: 13275 RVA: 0x0004F485 File Offset: 0x0004D685
		public unsafe string AnchorName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_AnchorName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FARGeoAnchorUpdatePayload.__PropertyOffset_AnchorName)), value);
			}
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x0004F49A File Offset: 0x0004D69A
		public FARGeoAnchorUpdatePayload()
		{
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x0004F4A2 File Offset: 0x0004D6A2
		public FARGeoAnchorUpdatePayload(FARSessionPayload SessionPayload, FTransform WorldTransform, float Longitude, float Latitude, float AltitudeMeters, EARAltitudeSource AltitudeSource, string AnchorName)
		{
			this.SessionPayload = SessionPayload;
			this.WorldTransform = WorldTransform;
			this.Longitude = Longitude;
			this.Latitude = Latitude;
			this.AltitudeMeters = AltitudeMeters;
			this.AltitudeSource = AltitudeSource;
			this.AnchorName = AnchorName;
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x0004F4DF File Offset: 0x0004D6DF
		protected override IntPtr GetUStructPtr()
		{
			return FARGeoAnchorUpdatePayload.StaticStruct();
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x0004F4EB File Offset: 0x0004D6EB
		[NullableContext(2)]
		public FARGeoAnchorUpdatePayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x0004F4F5 File Offset: 0x0004D6F5
		public FARGeoAnchorUpdatePayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x0004F500 File Offset: 0x0004D700
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARGeoAnchorUpdatePayload(Pointer, false, true);
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x0004F50A File Offset: 0x0004D70A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARGeoAnchorUpdatePayload(Pointer, MemoryOwner);
		}

		// Token: 0x0400167B RID: 5755
		public const string __ObjectPath = "/Script/AugmentedReality.ARGeoAnchorUpdatePayload";

		// Token: 0x0400167C RID: 5756
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400167D RID: 5757
		internal static int __PropertyOffset_SessionPayload;

		// Token: 0x0400167E RID: 5758
		[Nullable(2)]
		private FARSessionPayload _SessionPayload;

		// Token: 0x0400167F RID: 5759
		internal static int __PropertyOffset_WorldTransform;

		// Token: 0x04001680 RID: 5760
		internal static int __PropertyOffset_Longitude;

		// Token: 0x04001681 RID: 5761
		internal static int __PropertyOffset_Latitude;

		// Token: 0x04001682 RID: 5762
		internal static int __PropertyOffset_AltitudeMeters;

		// Token: 0x04001683 RID: 5763
		internal static int __PropertyOffset_AltitudeSource;

		// Token: 0x04001684 RID: 5764
		internal static int __PropertyOffset_AnchorName;
	}
}
