using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020009C5 RID: 2501
	[UnrealObjectPath("/Script/Engine.DistanceDatum")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FDistanceDatum : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008DAD RID: 36269 RVA: 0x000CA87D File Offset: 0x000C8A7D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDistanceDatum._ScriptStructPtr != 0) ? FDistanceDatum._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DistanceDatum", ref FDistanceDatum._ScriptStructPtr);
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x06008DAE RID: 36270 RVA: 0x000CA8A1 File Offset: 0x000C8AA1
		// (set) Token: 0x06008DAF RID: 36271 RVA: 0x000CA8B1 File Offset: 0x000C8AB1
		public unsafe float FadeInDistanceStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistanceDatum.__PropertyOffset_FadeInDistanceStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistanceDatum.__PropertyOffset_FadeInDistanceStart) = value;
			}
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x06008DB0 RID: 36272 RVA: 0x000CA8C2 File Offset: 0x000C8AC2
		// (set) Token: 0x06008DB1 RID: 36273 RVA: 0x000CA8D2 File Offset: 0x000C8AD2
		public unsafe float FadeInDistanceEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistanceDatum.__PropertyOffset_FadeInDistanceEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistanceDatum.__PropertyOffset_FadeInDistanceEnd) = value;
			}
		}

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x06008DB2 RID: 36274 RVA: 0x000CA8E3 File Offset: 0x000C8AE3
		// (set) Token: 0x06008DB3 RID: 36275 RVA: 0x000CA8F3 File Offset: 0x000C8AF3
		public unsafe float FadeOutDistanceStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistanceDatum.__PropertyOffset_FadeOutDistanceStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistanceDatum.__PropertyOffset_FadeOutDistanceStart) = value;
			}
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x06008DB4 RID: 36276 RVA: 0x000CA904 File Offset: 0x000C8B04
		// (set) Token: 0x06008DB5 RID: 36277 RVA: 0x000CA914 File Offset: 0x000C8B14
		public unsafe float FadeOutDistanceEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistanceDatum.__PropertyOffset_FadeOutDistanceEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistanceDatum.__PropertyOffset_FadeOutDistanceEnd) = value;
			}
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x06008DB6 RID: 36278 RVA: 0x000CA925 File Offset: 0x000C8B25
		// (set) Token: 0x06008DB7 RID: 36279 RVA: 0x000CA935 File Offset: 0x000C8B35
		public unsafe float Volume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistanceDatum.__PropertyOffset_Volume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistanceDatum.__PropertyOffset_Volume) = value;
			}
		}

		// Token: 0x06008DB8 RID: 36280 RVA: 0x000CA946 File Offset: 0x000C8B46
		public FDistanceDatum()
		{
		}

		// Token: 0x06008DB9 RID: 36281 RVA: 0x000CA94E File Offset: 0x000C8B4E
		public FDistanceDatum(float FadeInDistanceStart, float FadeInDistanceEnd, float FadeOutDistanceStart, float FadeOutDistanceEnd, float Volume)
		{
			this.FadeInDistanceStart = FadeInDistanceStart;
			this.FadeInDistanceEnd = FadeInDistanceEnd;
			this.FadeOutDistanceStart = FadeOutDistanceStart;
			this.FadeOutDistanceEnd = FadeOutDistanceEnd;
			this.Volume = Volume;
		}

		// Token: 0x06008DBA RID: 36282 RVA: 0x000CA97B File Offset: 0x000C8B7B
		protected override IntPtr GetUStructPtr()
		{
			return FDistanceDatum.StaticStruct();
		}

		// Token: 0x06008DBB RID: 36283 RVA: 0x000CA987 File Offset: 0x000C8B87
		[NullableContext(2)]
		public FDistanceDatum(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008DBC RID: 36284 RVA: 0x000CA991 File Offset: 0x000C8B91
		public FDistanceDatum(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008DBD RID: 36285 RVA: 0x000CA99C File Offset: 0x000C8B9C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDistanceDatum(Pointer, false, true);
		}

		// Token: 0x06008DBE RID: 36286 RVA: 0x000CA9A6 File Offset: 0x000C8BA6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDistanceDatum(Pointer, MemoryOwner);
		}

		// Token: 0x0400433E RID: 17214
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.DistanceDatum";

		// Token: 0x0400433F RID: 17215
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004340 RID: 17216
		internal static int __PropertyOffset_FadeInDistanceStart;

		// Token: 0x04004341 RID: 17217
		internal static int __PropertyOffset_FadeInDistanceEnd;

		// Token: 0x04004342 RID: 17218
		internal static int __PropertyOffset_FadeOutDistanceStart;

		// Token: 0x04004343 RID: 17219
		internal static int __PropertyOffset_FadeOutDistanceEnd;

		// Token: 0x04004344 RID: 17220
		internal static int __PropertyOffset_Volume;
	}
}
