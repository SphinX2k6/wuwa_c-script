using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001243 RID: 4675
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.VOscillator")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FVOscillator : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060112EA RID: 70378 RVA: 0x0019360B File Offset: 0x0019180B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVOscillator._ScriptStructPtr != 0) ? FVOscillator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VOscillator", ref FVOscillator._ScriptStructPtr);
		}

		// Token: 0x170042FA RID: 17146
		// (get) Token: 0x060112EB RID: 70379 RVA: 0x00193630 File Offset: 0x00191830
		// (set) Token: 0x060112EC RID: 70380 RVA: 0x00193673 File Offset: 0x00191873
		public FFOscillator X
		{
			get
			{
				base.FastCheckIsValid();
				FFOscillator result;
				if ((result = this._X) == null)
				{
					result = (this._X = new FFOscillator(base.NativePtr + (IntPtr)FVOscillator.__PropertyOffset_X, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFOscillator.StaticStruct(), base.NativePtr + (IntPtr)FVOscillator.__PropertyOffset_X, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170042FB RID: 17147
		// (get) Token: 0x060112ED RID: 70381 RVA: 0x00193694 File Offset: 0x00191894
		// (set) Token: 0x060112EE RID: 70382 RVA: 0x001936D7 File Offset: 0x001918D7
		public FFOscillator Y
		{
			get
			{
				base.FastCheckIsValid();
				FFOscillator result;
				if ((result = this._Y) == null)
				{
					result = (this._Y = new FFOscillator(base.NativePtr + (IntPtr)FVOscillator.__PropertyOffset_Y, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFOscillator.StaticStruct(), base.NativePtr + (IntPtr)FVOscillator.__PropertyOffset_Y, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170042FC RID: 17148
		// (get) Token: 0x060112EF RID: 70383 RVA: 0x001936F8 File Offset: 0x001918F8
		// (set) Token: 0x060112F0 RID: 70384 RVA: 0x0019373B File Offset: 0x0019193B
		public FFOscillator Z
		{
			get
			{
				base.FastCheckIsValid();
				FFOscillator result;
				if ((result = this._Z) == null)
				{
					result = (this._Z = new FFOscillator(base.NativePtr + (IntPtr)FVOscillator.__PropertyOffset_Z, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFOscillator.StaticStruct(), base.NativePtr + (IntPtr)FVOscillator.__PropertyOffset_Z, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060112F1 RID: 70385 RVA: 0x0019375C File Offset: 0x0019195C
		public FVOscillator()
		{
		}

		// Token: 0x060112F2 RID: 70386 RVA: 0x00193764 File Offset: 0x00191964
		public FVOscillator(FFOscillator X, FFOscillator Y, FFOscillator Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}

		// Token: 0x060112F3 RID: 70387 RVA: 0x00193781 File Offset: 0x00191981
		protected override IntPtr GetUStructPtr()
		{
			return FVOscillator.StaticStruct();
		}

		// Token: 0x060112F4 RID: 70388 RVA: 0x0019378D File Offset: 0x0019198D
		[NullableContext(2)]
		public FVOscillator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060112F5 RID: 70389 RVA: 0x00193797 File Offset: 0x00191997
		public FVOscillator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060112F6 RID: 70390 RVA: 0x001937A2 File Offset: 0x001919A2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVOscillator(Pointer, false, true);
		}

		// Token: 0x060112F7 RID: 70391 RVA: 0x001937AC File Offset: 0x001919AC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVOscillator(Pointer, MemoryOwner);
		}

		// Token: 0x04009308 RID: 37640
		public const string __ObjectPath = "/Script/Engine.VOscillator";

		// Token: 0x04009309 RID: 37641
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400930A RID: 37642
		internal static int __PropertyOffset_X;

		// Token: 0x0400930B RID: 37643
		[Nullable(2)]
		private FFOscillator _X;

		// Token: 0x0400930C RID: 37644
		internal static int __PropertyOffset_Y;

		// Token: 0x0400930D RID: 37645
		[Nullable(2)]
		private FFOscillator _Y;

		// Token: 0x0400930E RID: 37646
		internal static int __PropertyOffset_Z;

		// Token: 0x0400930F RID: 37647
		[Nullable(2)]
		private FFOscillator _Z;
	}
}
