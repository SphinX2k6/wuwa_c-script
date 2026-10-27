using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002300 RID: 8960
	[UnrealObjectPath("/Script/MovieSceneCapture.CaptureResolution")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FCaptureResolution : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021F3A RID: 139066 RVA: 0x003235B4 File Offset: 0x003217B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCaptureResolution._ScriptStructPtr != 0) ? FCaptureResolution._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneCapture.CaptureResolution", ref FCaptureResolution._ScriptStructPtr);
		}

		// Token: 0x1700833B RID: 33595
		// (get) Token: 0x06021F3B RID: 139067 RVA: 0x003235D8 File Offset: 0x003217D8
		// (set) Token: 0x06021F3C RID: 139068 RVA: 0x003235E8 File Offset: 0x003217E8
		public unsafe int ResX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCaptureResolution.__PropertyOffset_ResX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCaptureResolution.__PropertyOffset_ResX) = value;
			}
		}

		// Token: 0x1700833C RID: 33596
		// (get) Token: 0x06021F3D RID: 139069 RVA: 0x003235F9 File Offset: 0x003217F9
		// (set) Token: 0x06021F3E RID: 139070 RVA: 0x00323609 File Offset: 0x00321809
		public unsafe int ResY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCaptureResolution.__PropertyOffset_ResY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCaptureResolution.__PropertyOffset_ResY) = value;
			}
		}

		// Token: 0x06021F3F RID: 139071 RVA: 0x0032361A File Offset: 0x0032181A
		public FCaptureResolution()
		{
		}

		// Token: 0x06021F40 RID: 139072 RVA: 0x00323622 File Offset: 0x00321822
		public FCaptureResolution(int ResX, int ResY)
		{
			this.ResX = ResX;
			this.ResY = ResY;
		}

		// Token: 0x06021F41 RID: 139073 RVA: 0x00323638 File Offset: 0x00321838
		protected override IntPtr GetUStructPtr()
		{
			return FCaptureResolution.StaticStruct();
		}

		// Token: 0x06021F42 RID: 139074 RVA: 0x00323644 File Offset: 0x00321844
		[NullableContext(2)]
		public FCaptureResolution(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021F43 RID: 139075 RVA: 0x0032364E File Offset: 0x0032184E
		public FCaptureResolution(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021F44 RID: 139076 RVA: 0x00323659 File Offset: 0x00321859
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCaptureResolution(Pointer, false, true);
		}

		// Token: 0x06021F45 RID: 139077 RVA: 0x00323663 File Offset: 0x00321863
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCaptureResolution(Pointer, MemoryOwner);
		}

		// Token: 0x040121BD RID: 74173
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneCapture.CaptureResolution";

		// Token: 0x040121BE RID: 74174
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040121BF RID: 74175
		internal static int __PropertyOffset_ResX;

		// Token: 0x040121C0 RID: 74176
		internal static int __PropertyOffset_ResY;
	}
}
