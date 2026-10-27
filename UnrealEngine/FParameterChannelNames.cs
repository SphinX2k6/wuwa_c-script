using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F3D RID: 3901
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParameterChannelNames")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FParameterChannelNames : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D26B RID: 53867 RVA: 0x00134585 File Offset: 0x00132785
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParameterChannelNames._ScriptStructPtr != 0) ? FParameterChannelNames._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ParameterChannelNames", ref FParameterChannelNames._ScriptStructPtr);
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x0600D26C RID: 53868 RVA: 0x001345AC File Offset: 0x001327AC
		// (set) Token: 0x0600D26D RID: 53869 RVA: 0x001345EF File Offset: 0x001327EF
		public unsafe FText R
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._R) == null)
				{
					result = (this._R = new FText(base.NativePtr + (IntPtr)FParameterChannelNames.__PropertyOffset_R, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FParameterChannelNames.__PropertyOffset_R)), value.NativePtr, 1);
			}
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x0600D26E RID: 53870 RVA: 0x0013460C File Offset: 0x0013280C
		// (set) Token: 0x0600D26F RID: 53871 RVA: 0x0013464F File Offset: 0x0013284F
		public unsafe FText G
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._G) == null)
				{
					result = (this._G = new FText(base.NativePtr + (IntPtr)FParameterChannelNames.__PropertyOffset_G, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FParameterChannelNames.__PropertyOffset_G)), value.NativePtr, 1);
			}
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x0600D270 RID: 53872 RVA: 0x0013466C File Offset: 0x0013286C
		// (set) Token: 0x0600D271 RID: 53873 RVA: 0x001346AF File Offset: 0x001328AF
		public unsafe FText B
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FText(base.NativePtr + (IntPtr)FParameterChannelNames.__PropertyOffset_B, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FParameterChannelNames.__PropertyOffset_B)), value.NativePtr, 1);
			}
		}

		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x0600D272 RID: 53874 RVA: 0x001346CC File Offset: 0x001328CC
		// (set) Token: 0x0600D273 RID: 53875 RVA: 0x0013470F File Offset: 0x0013290F
		public unsafe FText A
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FText(base.NativePtr + (IntPtr)FParameterChannelNames.__PropertyOffset_A, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FParameterChannelNames.__PropertyOffset_A)), value.NativePtr, 1);
			}
		}

		// Token: 0x0600D274 RID: 53876 RVA: 0x0013472A File Offset: 0x0013292A
		public FParameterChannelNames()
		{
		}

		// Token: 0x0600D275 RID: 53877 RVA: 0x00134732 File Offset: 0x00132932
		public FParameterChannelNames(FText R, FText G, FText B, FText A)
		{
			this.R = R;
			this.G = G;
			this.B = B;
			this.A = A;
		}

		// Token: 0x0600D276 RID: 53878 RVA: 0x00134757 File Offset: 0x00132957
		protected override IntPtr GetUStructPtr()
		{
			return FParameterChannelNames.StaticStruct();
		}

		// Token: 0x0600D277 RID: 53879 RVA: 0x00134763 File Offset: 0x00132963
		[NullableContext(2)]
		public FParameterChannelNames(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D278 RID: 53880 RVA: 0x0013476D File Offset: 0x0013296D
		public FParameterChannelNames(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D279 RID: 53881 RVA: 0x00134778 File Offset: 0x00132978
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParameterChannelNames(Pointer, false, true);
		}

		// Token: 0x0600D27A RID: 53882 RVA: 0x00134782 File Offset: 0x00132982
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParameterChannelNames(Pointer, MemoryOwner);
		}

		// Token: 0x040070EA RID: 28906
		public const string __ObjectPath = "/Script/Engine.ParameterChannelNames";

		// Token: 0x040070EB RID: 28907
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040070EC RID: 28908
		internal static int __PropertyOffset_R;

		// Token: 0x040070ED RID: 28909
		[Nullable(2)]
		private FText _R;

		// Token: 0x040070EE RID: 28910
		internal static int __PropertyOffset_G;

		// Token: 0x040070EF RID: 28911
		[Nullable(2)]
		private FText _G;

		// Token: 0x040070F0 RID: 28912
		internal static int __PropertyOffset_B;

		// Token: 0x040070F1 RID: 28913
		[Nullable(2)]
		private FText _B;

		// Token: 0x040070F2 RID: 28914
		internal static int __PropertyOffset_A;

		// Token: 0x040070F3 RID: 28915
		[Nullable(2)]
		private FText _A;
	}
}
