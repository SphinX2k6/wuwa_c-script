using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200052A RID: 1322
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigPose")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigPose : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004545 RID: 17733 RVA: 0x0006720C File Offset: 0x0006540C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigPose._ScriptStructPtr != 0) ? FRigPose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigPose", ref FRigPose._ScriptStructPtr);
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06004546 RID: 17734 RVA: 0x00067230 File Offset: 0x00065430
		// (set) Token: 0x06004547 RID: 17735 RVA: 0x00067273 File Offset: 0x00065473
		public TArray<FRigPoseElement> Elements
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigPoseElement> result;
				if ((result = this._Elements) == null)
				{
					result = (this._Elements = new TArray<FRigPoseElement>(base.NativePtr + (IntPtr)FRigPose.__PropertyOffset_Elements, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Elements.CopyAssign(value);
			}
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x00067281 File Offset: 0x00065481
		public FRigPose()
		{
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x00067289 File Offset: 0x00065489
		public FRigPose(TArray<FRigPoseElement> Elements)
		{
			this.Elements = Elements;
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x00067298 File Offset: 0x00065498
		protected override IntPtr GetUStructPtr()
		{
			return FRigPose.StaticStruct();
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x000672A4 File Offset: 0x000654A4
		[NullableContext(2)]
		public FRigPose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x000672AE File Offset: 0x000654AE
		public FRigPose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x000672B9 File Offset: 0x000654B9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigPose(Pointer, false, true);
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x000672C3 File Offset: 0x000654C3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigPose(Pointer, MemoryOwner);
		}

		// Token: 0x040021BD RID: 8637
		public const string __ObjectPath = "/Script/ControlRig.RigPose";

		// Token: 0x040021BE RID: 8638
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021BF RID: 8639
		internal static int __PropertyOffset_Elements;

		// Token: 0x040021C0 RID: 8640
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigPoseElement> _Elements;
	}
}
