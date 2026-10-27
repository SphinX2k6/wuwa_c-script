using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200033F RID: 831
	[UnrealObjectPath("/Script/AnimGraphRuntime.RotationLimit")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRotationLimit : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002E5B RID: 11867 RVA: 0x0004711A File Offset: 0x0004531A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRotationLimit._ScriptStructPtr != 0) ? FRotationLimit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.RotationLimit", ref FRotationLimit._ScriptStructPtr);
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06002E5C RID: 11868 RVA: 0x0004713E File Offset: 0x0004533E
		// (set) Token: 0x06002E5D RID: 11869 RVA: 0x00047152 File Offset: 0x00045352
		public unsafe FVector LimitMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationLimit.__PropertyOffset_LimitMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationLimit.__PropertyOffset_LimitMin) = value;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002E5E RID: 11870 RVA: 0x00047167 File Offset: 0x00045367
		// (set) Token: 0x06002E5F RID: 11871 RVA: 0x0004717B File Offset: 0x0004537B
		public unsafe FVector LimitMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationLimit.__PropertyOffset_LimitMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationLimit.__PropertyOffset_LimitMax) = value;
			}
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00047190 File Offset: 0x00045390
		public FRotationLimit()
		{
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x00047198 File Offset: 0x00045398
		public FRotationLimit(FVector LimitMin, FVector LimitMax)
		{
			this.LimitMin = LimitMin;
			this.LimitMax = LimitMax;
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x000471AE File Offset: 0x000453AE
		protected override IntPtr GetUStructPtr()
		{
			return FRotationLimit.StaticStruct();
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x000471BA File Offset: 0x000453BA
		[NullableContext(2)]
		public FRotationLimit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x000471C4 File Offset: 0x000453C4
		public FRotationLimit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x000471CF File Offset: 0x000453CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRotationLimit(Pointer, false, true);
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x000471D9 File Offset: 0x000453D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRotationLimit(Pointer, MemoryOwner);
		}

		// Token: 0x040013DE RID: 5086
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.RotationLimit";

		// Token: 0x040013DF RID: 5087
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040013E0 RID: 5088
		internal static int __PropertyOffset_LimitMin;

		// Token: 0x040013E1 RID: 5089
		internal static int __PropertyOffset_LimitMax;
	}
}
