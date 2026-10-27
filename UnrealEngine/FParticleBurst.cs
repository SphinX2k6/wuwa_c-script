using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F3F RID: 3903
	[UnrealObjectPath("/Script/Engine.ParticleBurst")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FParticleBurst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D287 RID: 53895 RVA: 0x0013484B File Offset: 0x00132A4B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParticleBurst._ScriptStructPtr != 0) ? FParticleBurst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ParticleBurst", ref FParticleBurst._ScriptStructPtr);
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x0600D288 RID: 53896 RVA: 0x0013486F File Offset: 0x00132A6F
		// (set) Token: 0x0600D289 RID: 53897 RVA: 0x0013487F File Offset: 0x00132A7F
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleBurst.__PropertyOffset_Count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleBurst.__PropertyOffset_Count) = value;
			}
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x0600D28A RID: 53898 RVA: 0x00134890 File Offset: 0x00132A90
		// (set) Token: 0x0600D28B RID: 53899 RVA: 0x001348A0 File Offset: 0x00132AA0
		public unsafe int CountLow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleBurst.__PropertyOffset_CountLow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleBurst.__PropertyOffset_CountLow) = value;
			}
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x0600D28C RID: 53900 RVA: 0x001348B1 File Offset: 0x00132AB1
		// (set) Token: 0x0600D28D RID: 53901 RVA: 0x001348C1 File Offset: 0x00132AC1
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleBurst.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleBurst.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x0600D28E RID: 53902 RVA: 0x001348D2 File Offset: 0x00132AD2
		public FParticleBurst()
		{
		}

		// Token: 0x0600D28F RID: 53903 RVA: 0x001348DA File Offset: 0x00132ADA
		public FParticleBurst(int Count, int CountLow, float Time)
		{
			this.Count = Count;
			this.CountLow = CountLow;
			this.Time = Time;
		}

		// Token: 0x0600D290 RID: 53904 RVA: 0x001348F7 File Offset: 0x00132AF7
		protected override IntPtr GetUStructPtr()
		{
			return FParticleBurst.StaticStruct();
		}

		// Token: 0x0600D291 RID: 53905 RVA: 0x00134903 File Offset: 0x00132B03
		[NullableContext(2)]
		public FParticleBurst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D292 RID: 53906 RVA: 0x0013490D File Offset: 0x00132B0D
		public FParticleBurst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D293 RID: 53907 RVA: 0x00134918 File Offset: 0x00132B18
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParticleBurst(Pointer, false, true);
		}

		// Token: 0x0600D294 RID: 53908 RVA: 0x00134922 File Offset: 0x00132B22
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParticleBurst(Pointer, MemoryOwner);
		}

		// Token: 0x040070F8 RID: 28920
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ParticleBurst";

		// Token: 0x040070F9 RID: 28921
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040070FA RID: 28922
		internal static int __PropertyOffset_Count;

		// Token: 0x040070FB RID: 28923
		internal static int __PropertyOffset_CountLow;

		// Token: 0x040070FC RID: 28924
		internal static int __PropertyOffset_Time;
	}
}
