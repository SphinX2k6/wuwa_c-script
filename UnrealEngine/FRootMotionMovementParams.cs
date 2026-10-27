using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200109E RID: 4254
	[UnrealObjectPath("/Script/Engine.RootMotionMovementParams")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRootMotionMovementParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F316 RID: 62230 RVA: 0x0016881A File Offset: 0x00166A1A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRootMotionMovementParams._ScriptStructPtr != 0) ? FRootMotionMovementParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RootMotionMovementParams", ref FRootMotionMovementParams._ScriptStructPtr);
		}

		// Token: 0x17003B31 RID: 15153
		// (get) Token: 0x0600F317 RID: 62231 RVA: 0x0016883E File Offset: 0x00166A3E
		// (set) Token: 0x0600F318 RID: 62232 RVA: 0x0016884E File Offset: 0x00166A4E
		public unsafe bool bHasRootMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_bHasRootMotion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_bHasRootMotion) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x0600F319 RID: 62233 RVA: 0x0016885F File Offset: 0x00166A5F
		// (set) Token: 0x0600F31A RID: 62234 RVA: 0x0016886F File Offset: 0x00166A6F
		public unsafe float BlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_BlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_BlendWeight) = value;
			}
		}

		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x0600F31B RID: 62235 RVA: 0x00168880 File Offset: 0x00166A80
		// (set) Token: 0x0600F31C RID: 62236 RVA: 0x00168890 File Offset: 0x00166A90
		public unsafe float AccumulatedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_AccumulatedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_AccumulatedTime) = value;
			}
		}

		// Token: 0x17003B34 RID: 15156
		// (get) Token: 0x0600F31D RID: 62237 RVA: 0x001688A1 File Offset: 0x00166AA1
		// (set) Token: 0x0600F31E RID: 62238 RVA: 0x001688B5 File Offset: 0x00166AB5
		public unsafe FTransform RootMotionTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_RootMotionTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_RootMotionTransform) = value;
			}
		}

		// Token: 0x0600F31F RID: 62239 RVA: 0x001688CA File Offset: 0x00166ACA
		public FRootMotionMovementParams()
		{
		}

		// Token: 0x0600F320 RID: 62240 RVA: 0x001688D2 File Offset: 0x00166AD2
		public FRootMotionMovementParams(bool bHasRootMotion, float BlendWeight, float AccumulatedTime, FTransform RootMotionTransform)
		{
			this.bHasRootMotion = bHasRootMotion;
			this.BlendWeight = BlendWeight;
			this.AccumulatedTime = AccumulatedTime;
			this.RootMotionTransform = RootMotionTransform;
		}

		// Token: 0x0600F321 RID: 62241 RVA: 0x001688F7 File Offset: 0x00166AF7
		protected override IntPtr GetUStructPtr()
		{
			return FRootMotionMovementParams.StaticStruct();
		}

		// Token: 0x0600F322 RID: 62242 RVA: 0x00168903 File Offset: 0x00166B03
		[NullableContext(2)]
		public FRootMotionMovementParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F323 RID: 62243 RVA: 0x0016890D File Offset: 0x00166B0D
		public FRootMotionMovementParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F324 RID: 62244 RVA: 0x00168918 File Offset: 0x00166B18
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRootMotionMovementParams(Pointer, false, true);
		}

		// Token: 0x0600F325 RID: 62245 RVA: 0x00168922 File Offset: 0x00166B22
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRootMotionMovementParams(Pointer, MemoryOwner);
		}

		// Token: 0x040083D4 RID: 33748
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RootMotionMovementParams";

		// Token: 0x040083D5 RID: 33749
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040083D6 RID: 33750
		internal static int __PropertyOffset_bHasRootMotion;

		// Token: 0x040083D7 RID: 33751
		internal static int __PropertyOffset_BlendWeight;

		// Token: 0x040083D8 RID: 33752
		internal static int __PropertyOffset_AccumulatedTime;

		// Token: 0x040083D9 RID: 33753
		internal static int __PropertyOffset_RootMotionTransform;
	}
}
