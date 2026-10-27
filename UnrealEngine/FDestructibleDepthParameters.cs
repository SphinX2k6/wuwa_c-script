using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000353 RID: 851
	[UnrealObjectPath("/Script/ApexDestruction.DestructibleDepthParameters")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FDestructibleDepthParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002F48 RID: 12104 RVA: 0x00048677 File Offset: 0x00046877
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDestructibleDepthParameters._ScriptStructPtr != 0) ? FDestructibleDepthParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ApexDestruction.DestructibleDepthParameters", ref FDestructibleDepthParameters._ScriptStructPtr);
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002F49 RID: 12105 RVA: 0x0004869B File Offset: 0x0004689B
		// (set) Token: 0x06002F4A RID: 12106 RVA: 0x000486AF File Offset: 0x000468AF
		public unsafe TEnumAsByte<EImpactDamageOverride> ImpactDamageOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleDepthParameters.__PropertyOffset_ImpactDamageOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleDepthParameters.__PropertyOffset_ImpactDamageOverride) = value;
			}
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x000486C4 File Offset: 0x000468C4
		public FDestructibleDepthParameters()
		{
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x000486CC File Offset: 0x000468CC
		public FDestructibleDepthParameters(TEnumAsByte<EImpactDamageOverride> ImpactDamageOverride)
		{
			this.ImpactDamageOverride = ImpactDamageOverride;
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x000486DB File Offset: 0x000468DB
		protected override IntPtr GetUStructPtr()
		{
			return FDestructibleDepthParameters.StaticStruct();
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x000486E7 File Offset: 0x000468E7
		[NullableContext(2)]
		public FDestructibleDepthParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x000486F1 File Offset: 0x000468F1
		public FDestructibleDepthParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x000486FC File Offset: 0x000468FC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDestructibleDepthParameters(Pointer, false, true);
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x00048706 File Offset: 0x00046906
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDestructibleDepthParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04001465 RID: 5221
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ApexDestruction.DestructibleDepthParameters";

		// Token: 0x04001466 RID: 5222
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001467 RID: 5223
		internal static int __PropertyOffset_ImpactDamageOverride;
	}
}
