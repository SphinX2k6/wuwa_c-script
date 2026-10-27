using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016F4 RID: 5876
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletDataChild")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroBulletDataChild : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015387 RID: 86919 RVA: 0x001F3158 File Offset: 0x001F1358
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBulletDataChild._ScriptStructPtr != 0) ? FKuroBulletDataChild._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.KuroBulletDataChild", ref FKuroBulletDataChild._ScriptStructPtr);
		}

		// Token: 0x170053EA RID: 21482
		// (get) Token: 0x06015388 RID: 86920 RVA: 0x001F317C File Offset: 0x001F137C
		// (set) Token: 0x06015389 RID: 86921 RVA: 0x001F318C File Offset: 0x001F138C
		public unsafe long BulletConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataChild.__PropertyOffset_BulletConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataChild.__PropertyOffset_BulletConfigId) = value;
			}
		}

		// Token: 0x170053EB RID: 21483
		// (get) Token: 0x0601538A RID: 86922 RVA: 0x001F319D File Offset: 0x001F139D
		// (set) Token: 0x0601538B RID: 86923 RVA: 0x001F31AD File Offset: 0x001F13AD
		public unsafe float Delay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataChild.__PropertyOffset_Delay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataChild.__PropertyOffset_Delay) = value;
			}
		}

		// Token: 0x170053EC RID: 21484
		// (get) Token: 0x0601538C RID: 86924 RVA: 0x001F31BE File Offset: 0x001F13BE
		// (set) Token: 0x0601538D RID: 86925 RVA: 0x001F31CE File Offset: 0x001F13CE
		public unsafe int Num
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataChild.__PropertyOffset_Num);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataChild.__PropertyOffset_Num) = value;
			}
		}

		// Token: 0x170053ED RID: 21485
		// (get) Token: 0x0601538E RID: 86926 RVA: 0x001F31DF File Offset: 0x001F13DF
		// (set) Token: 0x0601538F RID: 86927 RVA: 0x001F31EF File Offset: 0x001F13EF
		public unsafe float Interval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataChild.__PropertyOffset_Interval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataChild.__PropertyOffset_Interval) = value;
			}
		}

		// Token: 0x170053EE RID: 21486
		// (get) Token: 0x06015390 RID: 86928 RVA: 0x001F3200 File Offset: 0x001F1400
		// (set) Token: 0x06015391 RID: 86929 RVA: 0x001F3210 File Offset: 0x001F1410
		public unsafe EKuroBulletChildrenType Condition
		{
			get
			{
				return (EKuroBulletChildrenType)(*(base.NativePtr + (IntPtr)FKuroBulletDataChild.__PropertyOffset_Condition));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataChild.__PropertyOffset_Condition) = (byte)value;
			}
		}

		// Token: 0x06015392 RID: 86930 RVA: 0x001F3221 File Offset: 0x001F1421
		public FKuroBulletDataChild()
		{
		}

		// Token: 0x06015393 RID: 86931 RVA: 0x001F3229 File Offset: 0x001F1429
		public FKuroBulletDataChild(long BulletConfigId, float Delay, int Num, float Interval, EKuroBulletChildrenType Condition)
		{
			this.BulletConfigId = BulletConfigId;
			this.Delay = Delay;
			this.Num = Num;
			this.Interval = Interval;
			this.Condition = Condition;
		}

		// Token: 0x06015394 RID: 86932 RVA: 0x001F3256 File Offset: 0x001F1456
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBulletDataChild.StaticStruct();
		}

		// Token: 0x06015395 RID: 86933 RVA: 0x001F3262 File Offset: 0x001F1462
		[NullableContext(2)]
		public FKuroBulletDataChild(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015396 RID: 86934 RVA: 0x001F326C File Offset: 0x001F146C
		public FKuroBulletDataChild(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015397 RID: 86935 RVA: 0x001F3277 File Offset: 0x001F1477
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBulletDataChild(Pointer, false, true);
		}

		// Token: 0x06015398 RID: 86936 RVA: 0x001F3281 File Offset: 0x001F1481
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBulletDataChild(Pointer, MemoryOwner);
		}

		// Token: 0x0400B928 RID: 47400
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletDataChild";

		// Token: 0x0400B929 RID: 47401
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B92A RID: 47402
		internal static int __PropertyOffset_BulletConfigId;

		// Token: 0x0400B92B RID: 47403
		internal static int __PropertyOffset_Delay;

		// Token: 0x0400B92C RID: 47404
		internal static int __PropertyOffset_Num;

		// Token: 0x0400B92D RID: 47405
		internal static int __PropertyOffset_Interval;

		// Token: 0x0400B92E RID: 47406
		internal static int __PropertyOffset_Condition;
	}
}
