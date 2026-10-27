using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C1F RID: 7199
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.Particle_QiuQian")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FParticle_QiuQian : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BC6F RID: 113775 RVA: 0x0028E432 File Offset: 0x0028C632
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParticle_QiuQian._ScriptStructPtr != 0) ? FParticle_QiuQian._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.Particle_QiuQian", ref FParticle_QiuQian._ScriptStructPtr);
		}

		// Token: 0x17006FF6 RID: 28662
		// (get) Token: 0x0601BC70 RID: 113776 RVA: 0x0028E456 File Offset: 0x0028C656
		// (set) Token: 0x0601BC71 RID: 113777 RVA: 0x0028E46A File Offset: 0x0028C66A
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticle_QiuQian.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticle_QiuQian.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x17006FF7 RID: 28663
		// (get) Token: 0x0601BC72 RID: 113778 RVA: 0x0028E47F File Offset: 0x0028C67F
		// (set) Token: 0x0601BC73 RID: 113779 RVA: 0x0028E493 File Offset: 0x0028C693
		public unsafe FVector posFoe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticle_QiuQian.__PropertyOffset_posFoe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticle_QiuQian.__PropertyOffset_posFoe) = value;
			}
		}

		// Token: 0x17006FF8 RID: 28664
		// (get) Token: 0x0601BC74 RID: 113780 RVA: 0x0028E4A8 File Offset: 0x0028C6A8
		// (set) Token: 0x0601BC75 RID: 113781 RVA: 0x0028E4BC File Offset: 0x0028C6BC
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticle_QiuQian.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticle_QiuQian.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x17006FF9 RID: 28665
		// (get) Token: 0x0601BC76 RID: 113782 RVA: 0x0028E4D1 File Offset: 0x0028C6D1
		// (set) Token: 0x0601BC77 RID: 113783 RVA: 0x0028E4E5 File Offset: 0x0028C6E5
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticle_QiuQian.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticle_QiuQian.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x17006FFA RID: 28666
		// (get) Token: 0x0601BC78 RID: 113784 RVA: 0x0028E4FA File Offset: 0x0028C6FA
		// (set) Token: 0x0601BC79 RID: 113785 RVA: 0x0028E50A File Offset: 0x0028C70A
		public unsafe float m
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticle_QiuQian.__PropertyOffset_m);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticle_QiuQian.__PropertyOffset_m) = value;
			}
		}

		// Token: 0x0601BC7A RID: 113786 RVA: 0x0028E51B File Offset: 0x0028C71B
		public FParticle_QiuQian()
		{
		}

		// Token: 0x0601BC7B RID: 113787 RVA: 0x0028E523 File Offset: 0x0028C723
		public FParticle_QiuQian(FVector pos, FVector posFoe, FVector pos_bind, FVector vol, float m)
		{
			this.pos = pos;
			this.posFoe = posFoe;
			this.pos_bind = pos_bind;
			this.vol = vol;
			this.m = m;
		}

		// Token: 0x0601BC7C RID: 113788 RVA: 0x0028E550 File Offset: 0x0028C750
		protected override IntPtr GetUStructPtr()
		{
			return FParticle_QiuQian.StaticStruct();
		}

		// Token: 0x0601BC7D RID: 113789 RVA: 0x0028E55C File Offset: 0x0028C75C
		[NullableContext(2)]
		public FParticle_QiuQian(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BC7E RID: 113790 RVA: 0x0028E566 File Offset: 0x0028C766
		public FParticle_QiuQian(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BC7F RID: 113791 RVA: 0x0028E571 File Offset: 0x0028C771
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParticle_QiuQian(Pointer, false, true);
		}

		// Token: 0x0601BC80 RID: 113792 RVA: 0x0028E57B File Offset: 0x0028C77B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParticle_QiuQian(Pointer, MemoryOwner);
		}

		// Token: 0x0400EEE7 RID: 61159
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.Particle_QiuQian";

		// Token: 0x0400EEE8 RID: 61160
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EEE9 RID: 61161
		internal static int __PropertyOffset_pos;

		// Token: 0x0400EEEA RID: 61162
		internal static int __PropertyOffset_posFoe;

		// Token: 0x0400EEEB RID: 61163
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400EEEC RID: 61164
		internal static int __PropertyOffset_vol;

		// Token: 0x0400EEED RID: 61165
		internal static int __PropertyOffset_m;
	}
}
