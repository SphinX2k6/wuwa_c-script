using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013C8 RID: 5064
	[UnrealObjectPath("/Script/GameplayAbilities.WorldReticleParameters")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FWorldReticleParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060128D3 RID: 75987 RVA: 0x001B4C42 File Offset: 0x001B2E42
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldReticleParameters._ScriptStructPtr != 0) ? FWorldReticleParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.WorldReticleParameters", ref FWorldReticleParameters._ScriptStructPtr);
		}

		// Token: 0x1700480C RID: 18444
		// (get) Token: 0x060128D4 RID: 75988 RVA: 0x001B4C66 File Offset: 0x001B2E66
		// (set) Token: 0x060128D5 RID: 75989 RVA: 0x001B4C7A File Offset: 0x001B2E7A
		public unsafe FVector AOEScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldReticleParameters.__PropertyOffset_AOEScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldReticleParameters.__PropertyOffset_AOEScale) = value;
			}
		}

		// Token: 0x060128D6 RID: 75990 RVA: 0x001B4C8F File Offset: 0x001B2E8F
		public FWorldReticleParameters()
		{
		}

		// Token: 0x060128D7 RID: 75991 RVA: 0x001B4C97 File Offset: 0x001B2E97
		public FWorldReticleParameters(FVector AOEScale)
		{
			this.AOEScale = AOEScale;
		}

		// Token: 0x060128D8 RID: 75992 RVA: 0x001B4CA6 File Offset: 0x001B2EA6
		protected override IntPtr GetUStructPtr()
		{
			return FWorldReticleParameters.StaticStruct();
		}

		// Token: 0x060128D9 RID: 75993 RVA: 0x001B4CB2 File Offset: 0x001B2EB2
		[NullableContext(2)]
		public FWorldReticleParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060128DA RID: 75994 RVA: 0x001B4CBC File Offset: 0x001B2EBC
		public FWorldReticleParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060128DB RID: 75995 RVA: 0x001B4CC7 File Offset: 0x001B2EC7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldReticleParameters(Pointer, false, true);
		}

		// Token: 0x060128DC RID: 75996 RVA: 0x001B4CD1 File Offset: 0x001B2ED1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldReticleParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04009EA3 RID: 40611
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WorldReticleParameters";

		// Token: 0x04009EA4 RID: 40612
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009EA5 RID: 40613
		internal static int __PropertyOffset_AOEScale;
	}
}
