using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200034E RID: 846
	[UnrealObjectPath("/Script/ApexDestruction.DestructibleAdvancedParameters")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FDestructibleAdvancedParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002EE9 RID: 12009 RVA: 0x00047D55 File Offset: 0x00045F55
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDestructibleAdvancedParameters._ScriptStructPtr != 0) ? FDestructibleAdvancedParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ApexDestruction.DestructibleAdvancedParameters", ref FDestructibleAdvancedParameters._ScriptStructPtr);
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002EEA RID: 12010 RVA: 0x00047D79 File Offset: 0x00045F79
		// (set) Token: 0x06002EEB RID: 12011 RVA: 0x00047D89 File Offset: 0x00045F89
		public unsafe float DamageCap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleAdvancedParameters.__PropertyOffset_DamageCap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleAdvancedParameters.__PropertyOffset_DamageCap) = value;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x00047D9A File Offset: 0x00045F9A
		// (set) Token: 0x06002EED RID: 12013 RVA: 0x00047DAA File Offset: 0x00045FAA
		public unsafe float ImpactVelocityThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleAdvancedParameters.__PropertyOffset_ImpactVelocityThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleAdvancedParameters.__PropertyOffset_ImpactVelocityThreshold) = value;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x00047DBB File Offset: 0x00045FBB
		// (set) Token: 0x06002EEF RID: 12015 RVA: 0x00047DCB File Offset: 0x00045FCB
		public unsafe float MaxChunkSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleAdvancedParameters.__PropertyOffset_MaxChunkSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleAdvancedParameters.__PropertyOffset_MaxChunkSpeed) = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x00047DDC File Offset: 0x00045FDC
		// (set) Token: 0x06002EF1 RID: 12017 RVA: 0x00047DEC File Offset: 0x00045FEC
		public unsafe float FractureImpulseScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleAdvancedParameters.__PropertyOffset_FractureImpulseScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleAdvancedParameters.__PropertyOffset_FractureImpulseScale) = value;
			}
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x00047DFD File Offset: 0x00045FFD
		public FDestructibleAdvancedParameters()
		{
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x00047E05 File Offset: 0x00046005
		public FDestructibleAdvancedParameters(float DamageCap, float ImpactVelocityThreshold, float MaxChunkSpeed, float FractureImpulseScale)
		{
			this.DamageCap = DamageCap;
			this.ImpactVelocityThreshold = ImpactVelocityThreshold;
			this.MaxChunkSpeed = MaxChunkSpeed;
			this.FractureImpulseScale = FractureImpulseScale;
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x00047E2A File Offset: 0x0004602A
		protected override IntPtr GetUStructPtr()
		{
			return FDestructibleAdvancedParameters.StaticStruct();
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x00047E36 File Offset: 0x00046036
		[NullableContext(2)]
		public FDestructibleAdvancedParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x00047E40 File Offset: 0x00046040
		public FDestructibleAdvancedParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x00047E4B File Offset: 0x0004604B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDestructibleAdvancedParameters(Pointer, false, true);
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x00047E55 File Offset: 0x00046055
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDestructibleAdvancedParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04001436 RID: 5174
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ApexDestruction.DestructibleAdvancedParameters";

		// Token: 0x04001437 RID: 5175
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001438 RID: 5176
		internal static int __PropertyOffset_DamageCap;

		// Token: 0x04001439 RID: 5177
		internal static int __PropertyOffset_ImpactVelocityThreshold;

		// Token: 0x0400143A RID: 5178
		internal static int __PropertyOffset_MaxChunkSpeed;

		// Token: 0x0400143B RID: 5179
		internal static int __PropertyOffset_FractureImpulseScale;
	}
}
