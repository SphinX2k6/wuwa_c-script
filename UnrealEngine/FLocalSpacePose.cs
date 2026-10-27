using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D64 RID: 3428
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LocalSpacePose")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FLocalSpacePose : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B92F RID: 47407 RVA: 0x00107815 File Offset: 0x00105A15
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLocalSpacePose._ScriptStructPtr != 0) ? FLocalSpacePose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LocalSpacePose", ref FLocalSpacePose._ScriptStructPtr);
		}

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x0600B930 RID: 47408 RVA: 0x0010783C File Offset: 0x00105A3C
		// (set) Token: 0x0600B931 RID: 47409 RVA: 0x0010787F File Offset: 0x00105A7F
		public TArray<FTransform> Transforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Transforms) == null)
				{
					result = (this._Transforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FLocalSpacePose.__PropertyOffset_Transforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transforms.CopyAssign(value);
			}
		}

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x0600B932 RID: 47410 RVA: 0x00107890 File Offset: 0x00105A90
		// (set) Token: 0x0600B933 RID: 47411 RVA: 0x001078D3 File Offset: 0x00105AD3
		public TArray<FName> Names
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Names) == null)
				{
					result = (this._Names = new TArray<FName>(base.NativePtr + (IntPtr)FLocalSpacePose.__PropertyOffset_Names, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Names.CopyAssign(value);
			}
		}

		// Token: 0x0600B934 RID: 47412 RVA: 0x001078E1 File Offset: 0x00105AE1
		public FLocalSpacePose()
		{
		}

		// Token: 0x0600B935 RID: 47413 RVA: 0x001078E9 File Offset: 0x00105AE9
		public FLocalSpacePose(TArray<FTransform> Transforms, TArray<FName> Names)
		{
			this.Transforms = Transforms;
			this.Names = Names;
		}

		// Token: 0x0600B936 RID: 47414 RVA: 0x001078FF File Offset: 0x00105AFF
		protected override IntPtr GetUStructPtr()
		{
			return FLocalSpacePose.StaticStruct();
		}

		// Token: 0x0600B937 RID: 47415 RVA: 0x0010790B File Offset: 0x00105B0B
		[NullableContext(2)]
		public FLocalSpacePose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B938 RID: 47416 RVA: 0x00107915 File Offset: 0x00105B15
		public FLocalSpacePose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B939 RID: 47417 RVA: 0x00107920 File Offset: 0x00105B20
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLocalSpacePose(Pointer, false, true);
		}

		// Token: 0x0600B93A RID: 47418 RVA: 0x0010792A File Offset: 0x00105B2A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLocalSpacePose(Pointer, MemoryOwner);
		}

		// Token: 0x04006108 RID: 24840
		public const string __ObjectPath = "/Script/Engine.LocalSpacePose";

		// Token: 0x04006109 RID: 24841
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400610A RID: 24842
		internal static int __PropertyOffset_Transforms;

		// Token: 0x0400610B RID: 24843
		[Nullable(2)]
		private TArray<FTransform> _Transforms;

		// Token: 0x0400610C RID: 24844
		internal static int __PropertyOffset_Names;

		// Token: 0x0400610D RID: 24845
		[Nullable(2)]
		private TArray<FName> _Names;
	}
}
