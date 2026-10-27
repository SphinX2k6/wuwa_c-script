using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001082 RID: 4226
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RepAttachment")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRepAttachment : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F1A9 RID: 61865 RVA: 0x00166A42 File Offset: 0x00164C42
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRepAttachment._ScriptStructPtr != 0) ? FRepAttachment._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RepAttachment", ref FRepAttachment._ScriptStructPtr);
		}

		// Token: 0x17003AD6 RID: 15062
		// (get) Token: 0x0600F1AA RID: 61866 RVA: 0x00166A66 File Offset: 0x00164C66
		// (set) Token: 0x0600F1AB RID: 61867 RVA: 0x00166A7A File Offset: 0x00164C7A
		public unsafe AActor AttachParent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FRepAttachment.__PropertyOffset_AttachParent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRepAttachment.__PropertyOffset_AttachParent, value);
			}
		}

		// Token: 0x17003AD7 RID: 15063
		// (get) Token: 0x0600F1AC RID: 61868 RVA: 0x00166A8F File Offset: 0x00164C8F
		// (set) Token: 0x0600F1AD RID: 61869 RVA: 0x00166AA3 File Offset: 0x00164CA3
		public unsafe FVector_NetQuantize100 LocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepAttachment.__PropertyOffset_LocationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepAttachment.__PropertyOffset_LocationOffset) = value;
			}
		}

		// Token: 0x17003AD8 RID: 15064
		// (get) Token: 0x0600F1AE RID: 61870 RVA: 0x00166AB8 File Offset: 0x00164CB8
		// (set) Token: 0x0600F1AF RID: 61871 RVA: 0x00166ACC File Offset: 0x00164CCC
		public unsafe FVector_NetQuantize100 RelativeScale3D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepAttachment.__PropertyOffset_RelativeScale3D);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepAttachment.__PropertyOffset_RelativeScale3D) = value;
			}
		}

		// Token: 0x17003AD9 RID: 15065
		// (get) Token: 0x0600F1B0 RID: 61872 RVA: 0x00166AE1 File Offset: 0x00164CE1
		// (set) Token: 0x0600F1B1 RID: 61873 RVA: 0x00166AF5 File Offset: 0x00164CF5
		public unsafe FRotator RotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepAttachment.__PropertyOffset_RotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepAttachment.__PropertyOffset_RotationOffset) = value;
			}
		}

		// Token: 0x17003ADA RID: 15066
		// (get) Token: 0x0600F1B2 RID: 61874 RVA: 0x00166B0A File Offset: 0x00164D0A
		// (set) Token: 0x0600F1B3 RID: 61875 RVA: 0x00166B1E File Offset: 0x00164D1E
		public unsafe FName AttachSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepAttachment.__PropertyOffset_AttachSocket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepAttachment.__PropertyOffset_AttachSocket) = value;
			}
		}

		// Token: 0x17003ADB RID: 15067
		// (get) Token: 0x0600F1B4 RID: 61876 RVA: 0x00166B33 File Offset: 0x00164D33
		// (set) Token: 0x0600F1B5 RID: 61877 RVA: 0x00166B47 File Offset: 0x00164D47
		public unsafe USceneComponent AttachComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FRepAttachment.__PropertyOffset_AttachComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRepAttachment.__PropertyOffset_AttachComponent, value);
			}
		}

		// Token: 0x0600F1B6 RID: 61878 RVA: 0x00166B5C File Offset: 0x00164D5C
		public FRepAttachment()
		{
		}

		// Token: 0x0600F1B7 RID: 61879 RVA: 0x00166B64 File Offset: 0x00164D64
		[NullableContext(1)]
		public FRepAttachment(AActor AttachParent, FVector_NetQuantize100 LocationOffset, FVector_NetQuantize100 RelativeScale3D, FRotator RotationOffset, FName AttachSocket, USceneComponent AttachComponent)
		{
			this.AttachParent = AttachParent;
			this.LocationOffset = LocationOffset;
			this.RelativeScale3D = RelativeScale3D;
			this.RotationOffset = RotationOffset;
			this.AttachSocket = AttachSocket;
			this.AttachComponent = AttachComponent;
		}

		// Token: 0x0600F1B8 RID: 61880 RVA: 0x00166B99 File Offset: 0x00164D99
		protected override IntPtr GetUStructPtr()
		{
			return FRepAttachment.StaticStruct();
		}

		// Token: 0x0600F1B9 RID: 61881 RVA: 0x00166BA5 File Offset: 0x00164DA5
		public FRepAttachment(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F1BA RID: 61882 RVA: 0x00166BAF File Offset: 0x00164DAF
		public FRepAttachment(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F1BB RID: 61883 RVA: 0x00166BBA File Offset: 0x00164DBA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRepAttachment(Pointer, false, true);
		}

		// Token: 0x0600F1BC RID: 61884 RVA: 0x00166BC4 File Offset: 0x00164DC4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRepAttachment(Pointer, MemoryOwner);
		}

		// Token: 0x0400830D RID: 33549
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RepAttachment";

		// Token: 0x0400830E RID: 33550
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400830F RID: 33551
		internal static int __PropertyOffset_AttachParent;

		// Token: 0x04008310 RID: 33552
		internal static int __PropertyOffset_LocationOffset;

		// Token: 0x04008311 RID: 33553
		internal static int __PropertyOffset_RelativeScale3D;

		// Token: 0x04008312 RID: 33554
		internal static int __PropertyOffset_RotationOffset;

		// Token: 0x04008313 RID: 33555
		internal static int __PropertyOffset_AttachSocket;

		// Token: 0x04008314 RID: 33556
		internal static int __PropertyOffset_AttachComponent;
	}
}
