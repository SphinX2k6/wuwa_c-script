using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000962 RID: 2402
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ComponentSpacePose")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FComponentSpacePose : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060087B8 RID: 34744 RVA: 0x000C2647 File Offset: 0x000C0847
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FComponentSpacePose._ScriptStructPtr != 0) ? FComponentSpacePose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ComponentSpacePose", ref FComponentSpacePose._ScriptStructPtr);
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x060087B9 RID: 34745 RVA: 0x000C266C File Offset: 0x000C086C
		// (set) Token: 0x060087BA RID: 34746 RVA: 0x000C26AF File Offset: 0x000C08AF
		public TArray<FTransform> Transforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Transforms) == null)
				{
					result = (this._Transforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FComponentSpacePose.__PropertyOffset_Transforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transforms.CopyAssign(value);
			}
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x060087BB RID: 34747 RVA: 0x000C26C0 File Offset: 0x000C08C0
		// (set) Token: 0x060087BC RID: 34748 RVA: 0x000C2703 File Offset: 0x000C0903
		public TArray<FName> Names
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Names) == null)
				{
					result = (this._Names = new TArray<FName>(base.NativePtr + (IntPtr)FComponentSpacePose.__PropertyOffset_Names, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Names.CopyAssign(value);
			}
		}

		// Token: 0x060087BD RID: 34749 RVA: 0x000C2711 File Offset: 0x000C0911
		public FComponentSpacePose()
		{
		}

		// Token: 0x060087BE RID: 34750 RVA: 0x000C2719 File Offset: 0x000C0919
		public FComponentSpacePose(TArray<FTransform> Transforms, TArray<FName> Names)
		{
			this.Transforms = Transforms;
			this.Names = Names;
		}

		// Token: 0x060087BF RID: 34751 RVA: 0x000C272F File Offset: 0x000C092F
		protected override IntPtr GetUStructPtr()
		{
			return FComponentSpacePose.StaticStruct();
		}

		// Token: 0x060087C0 RID: 34752 RVA: 0x000C273B File Offset: 0x000C093B
		[NullableContext(2)]
		public FComponentSpacePose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087C1 RID: 34753 RVA: 0x000C2745 File Offset: 0x000C0945
		public FComponentSpacePose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087C2 RID: 34754 RVA: 0x000C2750 File Offset: 0x000C0950
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FComponentSpacePose(Pointer, false, true);
		}

		// Token: 0x060087C3 RID: 34755 RVA: 0x000C275A File Offset: 0x000C095A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FComponentSpacePose(Pointer, MemoryOwner);
		}

		// Token: 0x04004085 RID: 16517
		public const string __ObjectPath = "/Script/Engine.ComponentSpacePose";

		// Token: 0x04004086 RID: 16518
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004087 RID: 16519
		internal static int __PropertyOffset_Transforms;

		// Token: 0x04004088 RID: 16520
		[Nullable(2)]
		private TArray<FTransform> _Transforms;

		// Token: 0x04004089 RID: 16521
		internal static int __PropertyOffset_Names;

		// Token: 0x0400408A RID: 16522
		[Nullable(2)]
		private TArray<FName> _Names;
	}
}
