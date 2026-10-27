using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C76 RID: 3190
	[UnrealObjectPath("/Script/Engine.InteriorSettings")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FInteriorSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A1F8 RID: 41464 RVA: 0x000E601E File Offset: 0x000E421E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInteriorSettings._ScriptStructPtr != 0) ? FInteriorSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InteriorSettings", ref FInteriorSettings._ScriptStructPtr);
		}

		// Token: 0x17002689 RID: 9865
		// (get) Token: 0x0600A1F9 RID: 41465 RVA: 0x000E6042 File Offset: 0x000E4242
		// (set) Token: 0x0600A1FA RID: 41466 RVA: 0x000E6052 File Offset: 0x000E4252
		public unsafe bool bIsWorldSettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_bIsWorldSettings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_bIsWorldSettings) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700268A RID: 9866
		// (get) Token: 0x0600A1FB RID: 41467 RVA: 0x000E6063 File Offset: 0x000E4263
		// (set) Token: 0x0600A1FC RID: 41468 RVA: 0x000E6073 File Offset: 0x000E4273
		public unsafe float ExteriorVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_ExteriorVolume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_ExteriorVolume) = value;
			}
		}

		// Token: 0x1700268B RID: 9867
		// (get) Token: 0x0600A1FD RID: 41469 RVA: 0x000E6084 File Offset: 0x000E4284
		// (set) Token: 0x0600A1FE RID: 41470 RVA: 0x000E6094 File Offset: 0x000E4294
		public unsafe float ExteriorTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_ExteriorTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_ExteriorTime) = value;
			}
		}

		// Token: 0x1700268C RID: 9868
		// (get) Token: 0x0600A1FF RID: 41471 RVA: 0x000E60A5 File Offset: 0x000E42A5
		// (set) Token: 0x0600A200 RID: 41472 RVA: 0x000E60B5 File Offset: 0x000E42B5
		public unsafe float ExteriorLPF
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_ExteriorLPF);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_ExteriorLPF) = value;
			}
		}

		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x0600A201 RID: 41473 RVA: 0x000E60C6 File Offset: 0x000E42C6
		// (set) Token: 0x0600A202 RID: 41474 RVA: 0x000E60D6 File Offset: 0x000E42D6
		public unsafe float ExteriorLPFTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_ExteriorLPFTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_ExteriorLPFTime) = value;
			}
		}

		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x0600A203 RID: 41475 RVA: 0x000E60E7 File Offset: 0x000E42E7
		// (set) Token: 0x0600A204 RID: 41476 RVA: 0x000E60F7 File Offset: 0x000E42F7
		public unsafe float InteriorVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_InteriorVolume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_InteriorVolume) = value;
			}
		}

		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x0600A205 RID: 41477 RVA: 0x000E6108 File Offset: 0x000E4308
		// (set) Token: 0x0600A206 RID: 41478 RVA: 0x000E6118 File Offset: 0x000E4318
		public unsafe float InteriorTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_InteriorTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_InteriorTime) = value;
			}
		}

		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x0600A207 RID: 41479 RVA: 0x000E6129 File Offset: 0x000E4329
		// (set) Token: 0x0600A208 RID: 41480 RVA: 0x000E6139 File Offset: 0x000E4339
		public unsafe float InteriorLPF
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_InteriorLPF);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_InteriorLPF) = value;
			}
		}

		// Token: 0x17002691 RID: 9873
		// (get) Token: 0x0600A209 RID: 41481 RVA: 0x000E614A File Offset: 0x000E434A
		// (set) Token: 0x0600A20A RID: 41482 RVA: 0x000E615A File Offset: 0x000E435A
		public unsafe float InteriorLPFTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_InteriorLPFTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInteriorSettings.__PropertyOffset_InteriorLPFTime) = value;
			}
		}

		// Token: 0x0600A20B RID: 41483 RVA: 0x000E616B File Offset: 0x000E436B
		public FInteriorSettings()
		{
		}

		// Token: 0x0600A20C RID: 41484 RVA: 0x000E6174 File Offset: 0x000E4374
		public FInteriorSettings(bool bIsWorldSettings, float ExteriorVolume, float ExteriorTime, float ExteriorLPF, float ExteriorLPFTime, float InteriorVolume, float InteriorTime, float InteriorLPF, float InteriorLPFTime)
		{
			this.bIsWorldSettings = bIsWorldSettings;
			this.ExteriorVolume = ExteriorVolume;
			this.ExteriorTime = ExteriorTime;
			this.ExteriorLPF = ExteriorLPF;
			this.ExteriorLPFTime = ExteriorLPFTime;
			this.InteriorVolume = InteriorVolume;
			this.InteriorTime = InteriorTime;
			this.InteriorLPF = InteriorLPF;
			this.InteriorLPFTime = InteriorLPFTime;
		}

		// Token: 0x0600A20D RID: 41485 RVA: 0x000E61CC File Offset: 0x000E43CC
		protected override IntPtr GetUStructPtr()
		{
			return FInteriorSettings.StaticStruct();
		}

		// Token: 0x0600A20E RID: 41486 RVA: 0x000E61D8 File Offset: 0x000E43D8
		[NullableContext(2)]
		public FInteriorSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A20F RID: 41487 RVA: 0x000E61E2 File Offset: 0x000E43E2
		public FInteriorSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A210 RID: 41488 RVA: 0x000E61ED File Offset: 0x000E43ED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInteriorSettings(Pointer, false, true);
		}

		// Token: 0x0600A211 RID: 41489 RVA: 0x000E61F7 File Offset: 0x000E43F7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInteriorSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040058E4 RID: 22756
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InteriorSettings";

		// Token: 0x040058E5 RID: 22757
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040058E6 RID: 22758
		internal static int __PropertyOffset_bIsWorldSettings;

		// Token: 0x040058E7 RID: 22759
		internal static int __PropertyOffset_ExteriorVolume;

		// Token: 0x040058E8 RID: 22760
		internal static int __PropertyOffset_ExteriorTime;

		// Token: 0x040058E9 RID: 22761
		internal static int __PropertyOffset_ExteriorLPF;

		// Token: 0x040058EA RID: 22762
		internal static int __PropertyOffset_ExteriorLPFTime;

		// Token: 0x040058EB RID: 22763
		internal static int __PropertyOffset_InteriorVolume;

		// Token: 0x040058EC RID: 22764
		internal static int __PropertyOffset_InteriorTime;

		// Token: 0x040058ED RID: 22765
		internal static int __PropertyOffset_InteriorLPF;

		// Token: 0x040058EE RID: 22766
		internal static int __PropertyOffset_InteriorLPFTime;
	}
}
