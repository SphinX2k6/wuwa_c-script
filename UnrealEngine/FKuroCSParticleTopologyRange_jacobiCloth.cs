using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017B4 RID: 6068
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticleTopologyRange_jacobiCloth")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroCSParticleTopologyRange_jacobiCloth : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016131 RID: 90417 RVA: 0x00205716 File Offset: 0x00203916
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticleTopologyRange_jacobiCloth._ScriptStructPtr != 0) ? FKuroCSParticleTopologyRange_jacobiCloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticleTopologyRange_jacobiCloth", ref FKuroCSParticleTopologyRange_jacobiCloth._ScriptStructPtr);
		}

		// Token: 0x17005811 RID: 22545
		// (get) Token: 0x06016132 RID: 90418 RVA: 0x0020573A File Offset: 0x0020393A
		// (set) Token: 0x06016133 RID: 90419 RVA: 0x0020574A File Offset: 0x0020394A
		public unsafe int DistanceOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticleTopologyRange_jacobiCloth.__PropertyOffset_DistanceOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticleTopologyRange_jacobiCloth.__PropertyOffset_DistanceOffset) = value;
			}
		}

		// Token: 0x17005812 RID: 22546
		// (get) Token: 0x06016134 RID: 90420 RVA: 0x0020575B File Offset: 0x0020395B
		// (set) Token: 0x06016135 RID: 90421 RVA: 0x0020576B File Offset: 0x0020396B
		public unsafe int DistanceCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticleTopologyRange_jacobiCloth.__PropertyOffset_DistanceCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticleTopologyRange_jacobiCloth.__PropertyOffset_DistanceCount) = value;
			}
		}

		// Token: 0x17005813 RID: 22547
		// (get) Token: 0x06016136 RID: 90422 RVA: 0x0020577C File Offset: 0x0020397C
		// (set) Token: 0x06016137 RID: 90423 RVA: 0x0020578C File Offset: 0x0020398C
		public unsafe int TriangleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticleTopologyRange_jacobiCloth.__PropertyOffset_TriangleOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticleTopologyRange_jacobiCloth.__PropertyOffset_TriangleOffset) = value;
			}
		}

		// Token: 0x17005814 RID: 22548
		// (get) Token: 0x06016138 RID: 90424 RVA: 0x0020579D File Offset: 0x0020399D
		// (set) Token: 0x06016139 RID: 90425 RVA: 0x002057AD File Offset: 0x002039AD
		public unsafe int TriangleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticleTopologyRange_jacobiCloth.__PropertyOffset_TriangleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticleTopologyRange_jacobiCloth.__PropertyOffset_TriangleCount) = value;
			}
		}

		// Token: 0x0601613A RID: 90426 RVA: 0x002057BE File Offset: 0x002039BE
		public FKuroCSParticleTopologyRange_jacobiCloth()
		{
		}

		// Token: 0x0601613B RID: 90427 RVA: 0x002057C6 File Offset: 0x002039C6
		public FKuroCSParticleTopologyRange_jacobiCloth(int DistanceOffset, int DistanceCount, int TriangleOffset, int TriangleCount)
		{
			this.DistanceOffset = DistanceOffset;
			this.DistanceCount = DistanceCount;
			this.TriangleOffset = TriangleOffset;
			this.TriangleCount = TriangleCount;
		}

		// Token: 0x0601613C RID: 90428 RVA: 0x002057EB File Offset: 0x002039EB
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticleTopologyRange_jacobiCloth.StaticStruct();
		}

		// Token: 0x0601613D RID: 90429 RVA: 0x002057F7 File Offset: 0x002039F7
		[NullableContext(2)]
		public FKuroCSParticleTopologyRange_jacobiCloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601613E RID: 90430 RVA: 0x00205801 File Offset: 0x00203A01
		public FKuroCSParticleTopologyRange_jacobiCloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601613F RID: 90431 RVA: 0x0020580C File Offset: 0x00203A0C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticleTopologyRange_jacobiCloth(Pointer, false, true);
		}

		// Token: 0x06016140 RID: 90432 RVA: 0x00205816 File Offset: 0x00203A16
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticleTopologyRange_jacobiCloth(Pointer, MemoryOwner);
		}

		// Token: 0x0400C05E RID: 49246
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticleTopologyRange_jacobiCloth";

		// Token: 0x0400C05F RID: 49247
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C060 RID: 49248
		internal static int __PropertyOffset_DistanceOffset;

		// Token: 0x0400C061 RID: 49249
		internal static int __PropertyOffset_DistanceCount;

		// Token: 0x0400C062 RID: 49250
		internal static int __PropertyOffset_TriangleOffset;

		// Token: 0x0400C063 RID: 49251
		internal static int __PropertyOffset_TriangleCount;
	}
}
