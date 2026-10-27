using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002224 RID: 8740
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTime")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FLiveLinkTime : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021491 RID: 136337 RVA: 0x00311068 File Offset: 0x0030F268
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkTime._ScriptStructPtr != 0) ? FLiveLinkTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkTime", ref FLiveLinkTime._ScriptStructPtr);
		}

		// Token: 0x170081EE RID: 33262
		// (get) Token: 0x06021492 RID: 136338 RVA: 0x0031108C File Offset: 0x0030F28C
		// (set) Token: 0x06021493 RID: 136339 RVA: 0x0031109C File Offset: 0x0030F29C
		public unsafe double WorldTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTime.__PropertyOffset_WorldTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTime.__PropertyOffset_WorldTime) = value;
			}
		}

		// Token: 0x170081EF RID: 33263
		// (get) Token: 0x06021494 RID: 136340 RVA: 0x003110B0 File Offset: 0x0030F2B0
		// (set) Token: 0x06021495 RID: 136341 RVA: 0x003110F3 File Offset: 0x0030F2F3
		public FQualifiedFrameTime SceneTime
		{
			get
			{
				base.FastCheckIsValid();
				FQualifiedFrameTime result;
				if ((result = this._SceneTime) == null)
				{
					result = (this._SceneTime = new FQualifiedFrameTime(base.NativePtr + (IntPtr)FLiveLinkTime.__PropertyOffset_SceneTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FQualifiedFrameTime.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkTime.__PropertyOffset_SceneTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021496 RID: 136342 RVA: 0x00311114 File Offset: 0x0030F314
		public FLiveLinkTime()
		{
		}

		// Token: 0x06021497 RID: 136343 RVA: 0x0031111C File Offset: 0x0030F31C
		public FLiveLinkTime(double WorldTime, FQualifiedFrameTime SceneTime)
		{
			this.WorldTime = WorldTime;
			this.SceneTime = SceneTime;
		}

		// Token: 0x06021498 RID: 136344 RVA: 0x00311132 File Offset: 0x0030F332
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkTime.StaticStruct();
		}

		// Token: 0x06021499 RID: 136345 RVA: 0x0031113E File Offset: 0x0030F33E
		[NullableContext(2)]
		public FLiveLinkTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602149A RID: 136346 RVA: 0x00311148 File Offset: 0x0030F348
		public FLiveLinkTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602149B RID: 136347 RVA: 0x00311153 File Offset: 0x0030F353
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkTime(Pointer, false, true);
		}

		// Token: 0x0602149C RID: 136348 RVA: 0x0031115D File Offset: 0x0030F35D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkTime(Pointer, MemoryOwner);
		}

		// Token: 0x04011C09 RID: 72713
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTime";

		// Token: 0x04011C0A RID: 72714
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C0B RID: 72715
		internal static int __PropertyOffset_WorldTime;

		// Token: 0x04011C0C RID: 72716
		internal static int __PropertyOffset_SceneTime;

		// Token: 0x04011C0D RID: 72717
		[Nullable(2)]
		private FQualifiedFrameTime _SceneTime;
	}
}
