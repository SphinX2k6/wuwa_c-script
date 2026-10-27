using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FAC RID: 4012
	[UnrealObjectPath("/Script/Engine.ParticleModuleTypeDataAnimTrail")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UParticleModuleTypeDataAnimTrail : UParticleModuleTypeDataBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D7CC RID: 55244 RVA: 0x0013E388 File Offset: 0x0013C588
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleTypeDataAnimTrail._ClassPtr;
		}

		// Token: 0x0600D7CD RID: 55245 RVA: 0x0013E394 File Offset: 0x0013C594
		public UParticleModuleTypeDataAnimTrail() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTypeDataAnimTrail.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D7CE RID: 55246 RVA: 0x0013E3BC File Offset: 0x0013C5BC
		[NullableContext(1)]
		public UParticleModuleTypeDataAnimTrail(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTypeDataAnimTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0600D7CF RID: 55247 RVA: 0x0013E3EF File Offset: 0x0013C5EF
		// (set) Token: 0x0600D7D0 RID: 55248 RVA: 0x0013E408 File Offset: 0x0013C608
		public unsafe bool bDeadTrailsOnDeactivate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_bDeadTrailsOnDeactivate) & UParticleModuleTypeDataAnimTrail.__PropertyMask_bDeadTrailsOnDeactivate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_bDeadTrailsOnDeactivate) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_bDeadTrailsOnDeactivate) & ~UParticleModuleTypeDataAnimTrail.__PropertyMask_bDeadTrailsOnDeactivate) | (value ? UParticleModuleTypeDataAnimTrail.__PropertyMask_bDeadTrailsOnDeactivate : 0));
			}
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0600D7D1 RID: 55249 RVA: 0x0013E438 File Offset: 0x0013C638
		// (set) Token: 0x0600D7D2 RID: 55250 RVA: 0x0013E451 File Offset: 0x0013C651
		public unsafe bool bEnablePreviousTangentRecalculation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_bEnablePreviousTangentRecalculation) & UParticleModuleTypeDataAnimTrail.__PropertyMask_bEnablePreviousTangentRecalculation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_bEnablePreviousTangentRecalculation) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_bEnablePreviousTangentRecalculation) & ~UParticleModuleTypeDataAnimTrail.__PropertyMask_bEnablePreviousTangentRecalculation) | (value ? UParticleModuleTypeDataAnimTrail.__PropertyMask_bEnablePreviousTangentRecalculation : 0));
			}
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0600D7D3 RID: 55251 RVA: 0x0013E481 File Offset: 0x0013C681
		// (set) Token: 0x0600D7D4 RID: 55252 RVA: 0x0013E49A File Offset: 0x0013C69A
		public unsafe bool bTangentRecalculationEveryFrame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_bTangentRecalculationEveryFrame) & UParticleModuleTypeDataAnimTrail.__PropertyMask_bTangentRecalculationEveryFrame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_bTangentRecalculationEveryFrame) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_bTangentRecalculationEveryFrame) & ~UParticleModuleTypeDataAnimTrail.__PropertyMask_bTangentRecalculationEveryFrame) | (value ? UParticleModuleTypeDataAnimTrail.__PropertyMask_bTangentRecalculationEveryFrame : 0));
			}
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0600D7D5 RID: 55253 RVA: 0x0013E4CA File Offset: 0x0013C6CA
		// (set) Token: 0x0600D7D6 RID: 55254 RVA: 0x0013E4DA File Offset: 0x0013C6DA
		public unsafe float TilingDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_TilingDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_TilingDistance) = value;
			}
		}

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0600D7D7 RID: 55255 RVA: 0x0013E4EB File Offset: 0x0013C6EB
		// (set) Token: 0x0600D7D8 RID: 55256 RVA: 0x0013E4FB File Offset: 0x0013C6FB
		public unsafe float DistanceTessellationStepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_DistanceTessellationStepSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_DistanceTessellationStepSize) = value;
			}
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0600D7D9 RID: 55257 RVA: 0x0013E50C File Offset: 0x0013C70C
		// (set) Token: 0x0600D7DA RID: 55258 RVA: 0x0013E51C File Offset: 0x0013C71C
		public unsafe float TangentTessellationStepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_TangentTessellationStepSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_TangentTessellationStepSize) = value;
			}
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0600D7DB RID: 55259 RVA: 0x0013E52D File Offset: 0x0013C72D
		// (set) Token: 0x0600D7DC RID: 55260 RVA: 0x0013E53D File Offset: 0x0013C73D
		public unsafe float WidthTessellationStepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_WidthTessellationStepSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataAnimTrail.__PropertyOffset_WidthTessellationStepSize) = value;
			}
		}

		// Token: 0x0600D7DD RID: 55261 RVA: 0x0013E54E File Offset: 0x0013C74E
		static UParticleModuleTypeDataAnimTrail()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleTypeDataAnimTrail");
		}

		// Token: 0x0600D7DE RID: 55262 RVA: 0x0013E55C File Offset: 0x0013C75C
		protected UParticleModuleTypeDataAnimTrail(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040074D0 RID: 29904
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleTypeDataAnimTrail";

		// Token: 0x040074D1 RID: 29905
		private static IntPtr _ClassPtr;

		// Token: 0x040074D2 RID: 29906
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040074D3 RID: 29907
		internal static int __PropertyOffset_bDeadTrailsOnDeactivate;

		// Token: 0x040074D4 RID: 29908
		internal static byte __PropertyMask_bDeadTrailsOnDeactivate;

		// Token: 0x040074D5 RID: 29909
		internal static int __PropertyOffset_bEnablePreviousTangentRecalculation;

		// Token: 0x040074D6 RID: 29910
		internal static byte __PropertyMask_bEnablePreviousTangentRecalculation;

		// Token: 0x040074D7 RID: 29911
		internal static int __PropertyOffset_bTangentRecalculationEveryFrame;

		// Token: 0x040074D8 RID: 29912
		internal static byte __PropertyMask_bTangentRecalculationEveryFrame;

		// Token: 0x040074D9 RID: 29913
		internal static int __PropertyOffset_TilingDistance;

		// Token: 0x040074DA RID: 29914
		internal static int __PropertyOffset_DistanceTessellationStepSize;

		// Token: 0x040074DB RID: 29915
		internal static int __PropertyOffset_TangentTessellationStepSize;

		// Token: 0x040074DC RID: 29916
		internal static int __PropertyOffset_WidthTessellationStepSize;
	}
}
