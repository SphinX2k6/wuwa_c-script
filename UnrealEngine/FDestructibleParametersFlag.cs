using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000357 RID: 855
	[UnrealObjectPath("/Script/ApexDestruction.DestructibleParametersFlag")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FDestructibleParametersFlag : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002F84 RID: 12164 RVA: 0x00048D4D File Offset: 0x00046F4D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDestructibleParametersFlag._ScriptStructPtr != 0) ? FDestructibleParametersFlag._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ApexDestruction.DestructibleParametersFlag", ref FDestructibleParametersFlag._ScriptStructPtr);
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x00048D71 File Offset: 0x00046F71
		// (set) Token: 0x06002F86 RID: 12166 RVA: 0x00048D8A File Offset: 0x00046F8A
		public unsafe bool bAccumulateDamage
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bAccumulateDamage) & FDestructibleParametersFlag.__PropertyMask_bAccumulateDamage) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bAccumulateDamage) = ((*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bAccumulateDamage) & ~FDestructibleParametersFlag.__PropertyMask_bAccumulateDamage) | (value ? FDestructibleParametersFlag.__PropertyMask_bAccumulateDamage : 0));
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x00048DBA File Offset: 0x00046FBA
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x00048DD3 File Offset: 0x00046FD3
		public unsafe bool bAssetDefinedSupport
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bAssetDefinedSupport) & FDestructibleParametersFlag.__PropertyMask_bAssetDefinedSupport) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bAssetDefinedSupport) = ((*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bAssetDefinedSupport) & ~FDestructibleParametersFlag.__PropertyMask_bAssetDefinedSupport) | (value ? FDestructibleParametersFlag.__PropertyMask_bAssetDefinedSupport : 0));
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x00048E03 File Offset: 0x00047003
		// (set) Token: 0x06002F8A RID: 12170 RVA: 0x00048E1C File Offset: 0x0004701C
		public unsafe bool bWorldSupport
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bWorldSupport) & FDestructibleParametersFlag.__PropertyMask_bWorldSupport) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bWorldSupport) = ((*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bWorldSupport) & ~FDestructibleParametersFlag.__PropertyMask_bWorldSupport) | (value ? FDestructibleParametersFlag.__PropertyMask_bWorldSupport : 0));
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06002F8B RID: 12171 RVA: 0x00048E4C File Offset: 0x0004704C
		// (set) Token: 0x06002F8C RID: 12172 RVA: 0x00048E65 File Offset: 0x00047065
		public unsafe bool bDebrisTimeout
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bDebrisTimeout) & FDestructibleParametersFlag.__PropertyMask_bDebrisTimeout) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bDebrisTimeout) = ((*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bDebrisTimeout) & ~FDestructibleParametersFlag.__PropertyMask_bDebrisTimeout) | (value ? FDestructibleParametersFlag.__PropertyMask_bDebrisTimeout : 0));
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06002F8D RID: 12173 RVA: 0x00048E95 File Offset: 0x00047095
		// (set) Token: 0x06002F8E RID: 12174 RVA: 0x00048EAE File Offset: 0x000470AE
		public unsafe bool bDebrisMaxSeparation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bDebrisMaxSeparation) & FDestructibleParametersFlag.__PropertyMask_bDebrisMaxSeparation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bDebrisMaxSeparation) = ((*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bDebrisMaxSeparation) & ~FDestructibleParametersFlag.__PropertyMask_bDebrisMaxSeparation) | (value ? FDestructibleParametersFlag.__PropertyMask_bDebrisMaxSeparation : 0));
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06002F8F RID: 12175 RVA: 0x00048EDE File Offset: 0x000470DE
		// (set) Token: 0x06002F90 RID: 12176 RVA: 0x00048EF7 File Offset: 0x000470F7
		public unsafe bool bCrumbleSmallestChunks
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bCrumbleSmallestChunks) & FDestructibleParametersFlag.__PropertyMask_bCrumbleSmallestChunks) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bCrumbleSmallestChunks) = ((*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bCrumbleSmallestChunks) & ~FDestructibleParametersFlag.__PropertyMask_bCrumbleSmallestChunks) | (value ? FDestructibleParametersFlag.__PropertyMask_bCrumbleSmallestChunks : 0));
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x00048F27 File Offset: 0x00047127
		// (set) Token: 0x06002F92 RID: 12178 RVA: 0x00048F40 File Offset: 0x00047140
		public unsafe bool bAccurateRaycasts
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bAccurateRaycasts) & FDestructibleParametersFlag.__PropertyMask_bAccurateRaycasts) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bAccurateRaycasts) = ((*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bAccurateRaycasts) & ~FDestructibleParametersFlag.__PropertyMask_bAccurateRaycasts) | (value ? FDestructibleParametersFlag.__PropertyMask_bAccurateRaycasts : 0));
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06002F93 RID: 12179 RVA: 0x00048F70 File Offset: 0x00047170
		// (set) Token: 0x06002F94 RID: 12180 RVA: 0x00048F89 File Offset: 0x00047189
		public unsafe bool bUseValidBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bUseValidBounds) & FDestructibleParametersFlag.__PropertyMask_bUseValidBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bUseValidBounds) = ((*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bUseValidBounds) & ~FDestructibleParametersFlag.__PropertyMask_bUseValidBounds) | (value ? FDestructibleParametersFlag.__PropertyMask_bUseValidBounds : 0));
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x00048FB9 File Offset: 0x000471B9
		// (set) Token: 0x06002F96 RID: 12182 RVA: 0x00048FD2 File Offset: 0x000471D2
		public unsafe bool bFormExtendedStructures
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bFormExtendedStructures) & FDestructibleParametersFlag.__PropertyMask_bFormExtendedStructures) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bFormExtendedStructures) = ((*(base.NativePtr + (IntPtr)FDestructibleParametersFlag.__PropertyOffset_bFormExtendedStructures) & ~FDestructibleParametersFlag.__PropertyMask_bFormExtendedStructures) | (value ? FDestructibleParametersFlag.__PropertyMask_bFormExtendedStructures : 0));
			}
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x00049002 File Offset: 0x00047202
		public FDestructibleParametersFlag()
		{
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x0004900C File Offset: 0x0004720C
		public FDestructibleParametersFlag(bool bAccumulateDamage, bool bAssetDefinedSupport, bool bWorldSupport, bool bDebrisTimeout, bool bDebrisMaxSeparation, bool bCrumbleSmallestChunks, bool bAccurateRaycasts, bool bUseValidBounds, bool bFormExtendedStructures)
		{
			this.bAccumulateDamage = bAccumulateDamage;
			this.bAssetDefinedSupport = bAssetDefinedSupport;
			this.bWorldSupport = bWorldSupport;
			this.bDebrisTimeout = bDebrisTimeout;
			this.bDebrisMaxSeparation = bDebrisMaxSeparation;
			this.bCrumbleSmallestChunks = bCrumbleSmallestChunks;
			this.bAccurateRaycasts = bAccurateRaycasts;
			this.bUseValidBounds = bUseValidBounds;
			this.bFormExtendedStructures = bFormExtendedStructures;
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x00049064 File Offset: 0x00047264
		protected override IntPtr GetUStructPtr()
		{
			return FDestructibleParametersFlag.StaticStruct();
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x00049070 File Offset: 0x00047270
		[NullableContext(2)]
		public FDestructibleParametersFlag(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x0004907A File Offset: 0x0004727A
		public FDestructibleParametersFlag(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x00049085 File Offset: 0x00047285
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDestructibleParametersFlag(Pointer, false, true);
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x0004908F File Offset: 0x0004728F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDestructibleParametersFlag(Pointer, MemoryOwner);
		}

		// Token: 0x0400148C RID: 5260
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ApexDestruction.DestructibleParametersFlag";

		// Token: 0x0400148D RID: 5261
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400148E RID: 5262
		internal static int __PropertyOffset_bAccumulateDamage;

		// Token: 0x0400148F RID: 5263
		internal static byte __PropertyMask_bAccumulateDamage;

		// Token: 0x04001490 RID: 5264
		internal static int __PropertyOffset_bAssetDefinedSupport;

		// Token: 0x04001491 RID: 5265
		internal static byte __PropertyMask_bAssetDefinedSupport;

		// Token: 0x04001492 RID: 5266
		internal static int __PropertyOffset_bWorldSupport;

		// Token: 0x04001493 RID: 5267
		internal static byte __PropertyMask_bWorldSupport;

		// Token: 0x04001494 RID: 5268
		internal static int __PropertyOffset_bDebrisTimeout;

		// Token: 0x04001495 RID: 5269
		internal static byte __PropertyMask_bDebrisTimeout;

		// Token: 0x04001496 RID: 5270
		internal static int __PropertyOffset_bDebrisMaxSeparation;

		// Token: 0x04001497 RID: 5271
		internal static byte __PropertyMask_bDebrisMaxSeparation;

		// Token: 0x04001498 RID: 5272
		internal static int __PropertyOffset_bCrumbleSmallestChunks;

		// Token: 0x04001499 RID: 5273
		internal static byte __PropertyMask_bCrumbleSmallestChunks;

		// Token: 0x0400149A RID: 5274
		internal static int __PropertyOffset_bAccurateRaycasts;

		// Token: 0x0400149B RID: 5275
		internal static byte __PropertyMask_bAccurateRaycasts;

		// Token: 0x0400149C RID: 5276
		internal static int __PropertyOffset_bUseValidBounds;

		// Token: 0x0400149D RID: 5277
		internal static byte __PropertyMask_bUseValidBounds;

		// Token: 0x0400149E RID: 5278
		internal static int __PropertyOffset_bFormExtendedStructures;

		// Token: 0x0400149F RID: 5279
		internal static byte __PropertyMask_bFormExtendedStructures;
	}
}
