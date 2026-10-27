using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200262D RID: 9773
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Overlay.OverlayItem")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FOverlayItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024598 RID: 148888 RVA: 0x0035D166 File Offset: 0x0035B366
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOverlayItem._ScriptStructPtr != 0) ? FOverlayItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Overlay.OverlayItem", ref FOverlayItem._ScriptStructPtr);
		}

		// Token: 0x17008C10 RID: 35856
		// (get) Token: 0x06024599 RID: 148889 RVA: 0x0035D18C File Offset: 0x0035B38C
		// (set) Token: 0x0602459A RID: 148890 RVA: 0x0035D1CF File Offset: 0x0035B3CF
		public FTimespan StartTime
		{
			get
			{
				base.FastCheckIsValid();
				FTimespan result;
				if ((result = this._StartTime) == null)
				{
					result = (this._StartTime = new FTimespan(base.NativePtr + (IntPtr)FOverlayItem.__PropertyOffset_StartTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimespan.StaticStruct(), base.NativePtr + (IntPtr)FOverlayItem.__PropertyOffset_StartTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008C11 RID: 35857
		// (get) Token: 0x0602459B RID: 148891 RVA: 0x0035D1F0 File Offset: 0x0035B3F0
		// (set) Token: 0x0602459C RID: 148892 RVA: 0x0035D233 File Offset: 0x0035B433
		public FTimespan EndTime
		{
			get
			{
				base.FastCheckIsValid();
				FTimespan result;
				if ((result = this._EndTime) == null)
				{
					result = (this._EndTime = new FTimespan(base.NativePtr + (IntPtr)FOverlayItem.__PropertyOffset_EndTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimespan.StaticStruct(), base.NativePtr + (IntPtr)FOverlayItem.__PropertyOffset_EndTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008C12 RID: 35858
		// (get) Token: 0x0602459D RID: 148893 RVA: 0x0035D254 File Offset: 0x0035B454
		// (set) Token: 0x0602459E RID: 148894 RVA: 0x0035D268 File Offset: 0x0035B468
		public unsafe string Text
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FOverlayItem.__PropertyOffset_Text)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FOverlayItem.__PropertyOffset_Text)), value);
			}
		}

		// Token: 0x17008C13 RID: 35859
		// (get) Token: 0x0602459F RID: 148895 RVA: 0x0035D27D File Offset: 0x0035B47D
		// (set) Token: 0x060245A0 RID: 148896 RVA: 0x0035D291 File Offset: 0x0035B491
		public unsafe FVector2D Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOverlayItem.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOverlayItem.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x060245A1 RID: 148897 RVA: 0x0035D2A6 File Offset: 0x0035B4A6
		public FOverlayItem()
		{
		}

		// Token: 0x060245A2 RID: 148898 RVA: 0x0035D2AE File Offset: 0x0035B4AE
		public FOverlayItem(FTimespan StartTime, FTimespan EndTime, string Text, FVector2D Position)
		{
			this.StartTime = StartTime;
			this.EndTime = EndTime;
			this.Text = Text;
			this.Position = Position;
		}

		// Token: 0x060245A3 RID: 148899 RVA: 0x0035D2D3 File Offset: 0x0035B4D3
		protected override IntPtr GetUStructPtr()
		{
			return FOverlayItem.StaticStruct();
		}

		// Token: 0x060245A4 RID: 148900 RVA: 0x0035D2DF File Offset: 0x0035B4DF
		[NullableContext(2)]
		public FOverlayItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060245A5 RID: 148901 RVA: 0x0035D2E9 File Offset: 0x0035B4E9
		public FOverlayItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060245A6 RID: 148902 RVA: 0x0035D2F4 File Offset: 0x0035B4F4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOverlayItem(Pointer, false, true);
		}

		// Token: 0x060245A7 RID: 148903 RVA: 0x0035D2FE File Offset: 0x0035B4FE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOverlayItem(Pointer, MemoryOwner);
		}

		// Token: 0x04013809 RID: 79881
		public const string __ObjectPath = "/Script/Overlay.OverlayItem";

		// Token: 0x0401380A RID: 79882
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401380B RID: 79883
		internal static int __PropertyOffset_StartTime;

		// Token: 0x0401380C RID: 79884
		[Nullable(2)]
		private FTimespan _StartTime;

		// Token: 0x0401380D RID: 79885
		internal static int __PropertyOffset_EndTime;

		// Token: 0x0401380E RID: 79886
		[Nullable(2)]
		private FTimespan _EndTime;

		// Token: 0x0401380F RID: 79887
		internal static int __PropertyOffset_Text;

		// Token: 0x04013810 RID: 79888
		internal static int __PropertyOffset_Position;
	}
}
