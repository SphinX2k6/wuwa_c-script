using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200090C RID: 2316
	[UnrealObjectPath("/Script/Engine.CameraCutInfo")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FCameraCutInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007F54 RID: 32596 RVA: 0x000B6922 File Offset: 0x000B4B22
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraCutInfo._ScriptStructPtr != 0) ? FCameraCutInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CameraCutInfo", ref FCameraCutInfo._ScriptStructPtr);
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x06007F55 RID: 32597 RVA: 0x000B6946 File Offset: 0x000B4B46
		// (set) Token: 0x06007F56 RID: 32598 RVA: 0x000B695A File Offset: 0x000B4B5A
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraCutInfo.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraCutInfo.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x06007F57 RID: 32599 RVA: 0x000B696F File Offset: 0x000B4B6F
		// (set) Token: 0x06007F58 RID: 32600 RVA: 0x000B697F File Offset: 0x000B4B7F
		public unsafe float TimeStamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraCutInfo.__PropertyOffset_TimeStamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraCutInfo.__PropertyOffset_TimeStamp) = value;
			}
		}

		// Token: 0x06007F59 RID: 32601 RVA: 0x000B6990 File Offset: 0x000B4B90
		public FCameraCutInfo()
		{
		}

		// Token: 0x06007F5A RID: 32602 RVA: 0x000B6998 File Offset: 0x000B4B98
		public FCameraCutInfo(FVector Location, float TimeStamp)
		{
			this.Location = Location;
			this.TimeStamp = TimeStamp;
		}

		// Token: 0x06007F5B RID: 32603 RVA: 0x000B69AE File Offset: 0x000B4BAE
		protected override IntPtr GetUStructPtr()
		{
			return FCameraCutInfo.StaticStruct();
		}

		// Token: 0x06007F5C RID: 32604 RVA: 0x000B69BA File Offset: 0x000B4BBA
		[NullableContext(2)]
		public FCameraCutInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007F5D RID: 32605 RVA: 0x000B69C4 File Offset: 0x000B4BC4
		public FCameraCutInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007F5E RID: 32606 RVA: 0x000B69CF File Offset: 0x000B4BCF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraCutInfo(Pointer, false, true);
		}

		// Token: 0x06007F5F RID: 32607 RVA: 0x000B69D9 File Offset: 0x000B4BD9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraCutInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003D0E RID: 15630
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CameraCutInfo";

		// Token: 0x04003D0F RID: 15631
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003D10 RID: 15632
		internal static int __PropertyOffset_Location;

		// Token: 0x04003D11 RID: 15633
		internal static int __PropertyOffset_TimeStamp;
	}
}
