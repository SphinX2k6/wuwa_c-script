using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003A0 RID: 928
	[UnrealObjectPath("/Script/AugmentedReality.AREnvironmentProbeUpdatePayload")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAREnvironmentProbeUpdatePayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600336D RID: 13165 RVA: 0x0004EC24 File Offset: 0x0004CE24
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAREnvironmentProbeUpdatePayload._ScriptStructPtr != 0) ? FAREnvironmentProbeUpdatePayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.AREnvironmentProbeUpdatePayload", ref FAREnvironmentProbeUpdatePayload._ScriptStructPtr);
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x0600336E RID: 13166 RVA: 0x0004EC48 File Offset: 0x0004CE48
		// (set) Token: 0x0600336F RID: 13167 RVA: 0x0004EC5C File Offset: 0x0004CE5C
		public unsafe FTransform WorldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAREnvironmentProbeUpdatePayload.__PropertyOffset_WorldTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAREnvironmentProbeUpdatePayload.__PropertyOffset_WorldTransform) = value;
			}
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x0004EC71 File Offset: 0x0004CE71
		public FAREnvironmentProbeUpdatePayload()
		{
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x0004EC79 File Offset: 0x0004CE79
		public FAREnvironmentProbeUpdatePayload(FTransform WorldTransform)
		{
			this.WorldTransform = WorldTransform;
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x0004EC88 File Offset: 0x0004CE88
		protected override IntPtr GetUStructPtr()
		{
			return FAREnvironmentProbeUpdatePayload.StaticStruct();
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x0004EC94 File Offset: 0x0004CE94
		[NullableContext(2)]
		public FAREnvironmentProbeUpdatePayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x0004EC9E File Offset: 0x0004CE9E
		public FAREnvironmentProbeUpdatePayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x0004ECA9 File Offset: 0x0004CEA9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAREnvironmentProbeUpdatePayload(Pointer, false, true);
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x0004ECB3 File Offset: 0x0004CEB3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAREnvironmentProbeUpdatePayload(Pointer, MemoryOwner);
		}

		// Token: 0x04001658 RID: 5720
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.AREnvironmentProbeUpdatePayload";

		// Token: 0x04001659 RID: 5721
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400165A RID: 5722
		internal static int __PropertyOffset_WorldTransform;
	}
}
