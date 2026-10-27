using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010E8 RID: 4328
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ShearTrack")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FShearTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F86B RID: 63595 RVA: 0x0016F6D1 File Offset: 0x0016D8D1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FShearTrack._ScriptStructPtr != 0) ? FShearTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ShearTrack", ref FShearTrack._ScriptStructPtr);
		}

		// Token: 0x17003C86 RID: 15494
		// (get) Token: 0x0600F86C RID: 63596 RVA: 0x0016F6F8 File Offset: 0x0016D8F8
		// (set) Token: 0x0600F86D RID: 63597 RVA: 0x0016F73B File Offset: 0x0016D93B
		public TArray<FVector> ShearKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._ShearKeys) == null)
				{
					result = (this._ShearKeys = new TArray<FVector>(base.NativePtr + (IntPtr)FShearTrack.__PropertyOffset_ShearKeys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ShearKeys.CopyAssign(value);
			}
		}

		// Token: 0x17003C87 RID: 15495
		// (get) Token: 0x0600F86E RID: 63598 RVA: 0x0016F74C File Offset: 0x0016D94C
		// (set) Token: 0x0600F86F RID: 63599 RVA: 0x0016F78F File Offset: 0x0016D98F
		public TArray<float> Times
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<float>(base.NativePtr + (IntPtr)FShearTrack.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x0600F870 RID: 63600 RVA: 0x0016F79D File Offset: 0x0016D99D
		public FShearTrack()
		{
		}

		// Token: 0x0600F871 RID: 63601 RVA: 0x0016F7A5 File Offset: 0x0016D9A5
		public FShearTrack(TArray<FVector> ShearKeys, TArray<float> Times)
		{
			this.ShearKeys = ShearKeys;
			this.Times = Times;
		}

		// Token: 0x0600F872 RID: 63602 RVA: 0x0016F7BB File Offset: 0x0016D9BB
		protected override IntPtr GetUStructPtr()
		{
			return FShearTrack.StaticStruct();
		}

		// Token: 0x0600F873 RID: 63603 RVA: 0x0016F7C7 File Offset: 0x0016D9C7
		[NullableContext(2)]
		public FShearTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F874 RID: 63604 RVA: 0x0016F7D1 File Offset: 0x0016D9D1
		public FShearTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F875 RID: 63605 RVA: 0x0016F7DC File Offset: 0x0016D9DC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FShearTrack(Pointer, false, true);
		}

		// Token: 0x0600F876 RID: 63606 RVA: 0x0016F7E6 File Offset: 0x0016D9E6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FShearTrack(Pointer, MemoryOwner);
		}

		// Token: 0x04008637 RID: 34359
		public const string __ObjectPath = "/Script/Engine.ShearTrack";

		// Token: 0x04008638 RID: 34360
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008639 RID: 34361
		internal static int __PropertyOffset_ShearKeys;

		// Token: 0x0400863A RID: 34362
		[Nullable(2)]
		private TArray<FVector> _ShearKeys;

		// Token: 0x0400863B RID: 34363
		internal static int __PropertyOffset_Times;

		// Token: 0x0400863C RID: 34364
		[Nullable(2)]
		private TArray<float> _Times;
	}
}
