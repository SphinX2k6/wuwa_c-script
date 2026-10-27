using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000345 RID: 837
	[UnrealObjectPath("/Script/AnimGraphRuntime.WarpingVectorValue")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FWarpingVectorValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002EC0 RID: 11968 RVA: 0x000478CF File Offset: 0x00045ACF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWarpingVectorValue._ScriptStructPtr != 0) ? FWarpingVectorValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.WarpingVectorValue", ref FWarpingVectorValue._ScriptStructPtr);
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06002EC1 RID: 11969 RVA: 0x000478F3 File Offset: 0x00045AF3
		// (set) Token: 0x06002EC2 RID: 11970 RVA: 0x00047903 File Offset: 0x00045B03
		public unsafe EWarpingVectorMode Mode
		{
			get
			{
				return (EWarpingVectorMode)(*(base.NativePtr + (IntPtr)FWarpingVectorValue.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWarpingVectorValue.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06002EC3 RID: 11971 RVA: 0x00047914 File Offset: 0x00045B14
		// (set) Token: 0x06002EC4 RID: 11972 RVA: 0x00047928 File Offset: 0x00045B28
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWarpingVectorValue.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWarpingVectorValue.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x0004793D File Offset: 0x00045B3D
		public FWarpingVectorValue()
		{
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00047945 File Offset: 0x00045B45
		public FWarpingVectorValue(EWarpingVectorMode Mode, FVector Value)
		{
			this.Mode = Mode;
			this.Value = Value;
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x0004795B File Offset: 0x00045B5B
		protected override IntPtr GetUStructPtr()
		{
			return FWarpingVectorValue.StaticStruct();
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x00047967 File Offset: 0x00045B67
		[NullableContext(2)]
		public FWarpingVectorValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x00047971 File Offset: 0x00045B71
		public FWarpingVectorValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x0004797C File Offset: 0x00045B7C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWarpingVectorValue(Pointer, false, true);
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x00047986 File Offset: 0x00045B86
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWarpingVectorValue(Pointer, MemoryOwner);
		}

		// Token: 0x04001409 RID: 5129
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.WarpingVectorValue";

		// Token: 0x0400140A RID: 5130
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400140B RID: 5131
		internal static int __PropertyOffset_Mode;

		// Token: 0x0400140C RID: 5132
		internal static int __PropertyOffset_Value;
	}
}
