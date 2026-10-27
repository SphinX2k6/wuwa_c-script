using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007AD RID: 1965
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ActorCheckJsonParamsFirstFolders")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FActorCheckJsonParamsFirstFolders : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060068D4 RID: 26836 RVA: 0x000967EA File Offset: 0x000949EA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorCheckJsonParamsFirstFolders._ScriptStructPtr != 0) ? FActorCheckJsonParamsFirstFolders._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorCheckJsonParamsFirstFolders", ref FActorCheckJsonParamsFirstFolders._ScriptStructPtr);
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x060068D5 RID: 26837 RVA: 0x0009680E File Offset: 0x00094A0E
		// (set) Token: 0x060068D6 RID: 26838 RVA: 0x00096822 File Offset: 0x00094A22
		public unsafe string FirstName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsFirstFolders.__PropertyOffset_FirstName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsFirstFolders.__PropertyOffset_FirstName)), value);
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x060068D7 RID: 26839 RVA: 0x00096837 File Offset: 0x00094A37
		// (set) Token: 0x060068D8 RID: 26840 RVA: 0x0009684B File Offset: 0x00094A4B
		public unsafe string Regex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsFirstFolders.__PropertyOffset_Regex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsFirstFolders.__PropertyOffset_Regex)), value);
			}
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x060068D9 RID: 26841 RVA: 0x00096860 File Offset: 0x00094A60
		// (set) Token: 0x060068DA RID: 26842 RVA: 0x00096870 File Offset: 0x00094A70
		public unsafe uint SecondGroupIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorCheckJsonParamsFirstFolders.__PropertyOffset_SecondGroupIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorCheckJsonParamsFirstFolders.__PropertyOffset_SecondGroupIndex) = (int)value;
			}
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x060068DB RID: 26843 RVA: 0x00096884 File Offset: 0x00094A84
		// (set) Token: 0x060068DC RID: 26844 RVA: 0x000968C7 File Offset: 0x00094AC7
		public TArray<string> AdditionalDataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AdditionalDataLayers) == null)
				{
					result = (this._AdditionalDataLayers = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParamsFirstFolders.__PropertyOffset_AdditionalDataLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AdditionalDataLayers.CopyAssign(value);
			}
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x000968D5 File Offset: 0x00094AD5
		public FActorCheckJsonParamsFirstFolders()
		{
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x000968DD File Offset: 0x00094ADD
		public FActorCheckJsonParamsFirstFolders(string FirstName, string Regex, uint SecondGroupIndex, TArray<string> AdditionalDataLayers)
		{
			this.FirstName = FirstName;
			this.Regex = Regex;
			this.SecondGroupIndex = SecondGroupIndex;
			this.AdditionalDataLayers = AdditionalDataLayers;
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x00096902 File Offset: 0x00094B02
		protected override IntPtr GetUStructPtr()
		{
			return FActorCheckJsonParamsFirstFolders.StaticStruct();
		}

		// Token: 0x060068E0 RID: 26848 RVA: 0x0009690E File Offset: 0x00094B0E
		[NullableContext(2)]
		public FActorCheckJsonParamsFirstFolders(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x00096918 File Offset: 0x00094B18
		public FActorCheckJsonParamsFirstFolders(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x00096923 File Offset: 0x00094B23
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorCheckJsonParamsFirstFolders(Pointer, false, true);
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x0009692D File Offset: 0x00094B2D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorCheckJsonParamsFirstFolders(Pointer, MemoryOwner);
		}

		// Token: 0x04003293 RID: 12947
		public const string __ObjectPath = "/Script/Engine.ActorCheckJsonParamsFirstFolders";

		// Token: 0x04003294 RID: 12948
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003295 RID: 12949
		internal static int __PropertyOffset_FirstName;

		// Token: 0x04003296 RID: 12950
		internal static int __PropertyOffset_Regex;

		// Token: 0x04003297 RID: 12951
		internal static int __PropertyOffset_SecondGroupIndex;

		// Token: 0x04003298 RID: 12952
		internal static int __PropertyOffset_AdditionalDataLayers;

		// Token: 0x04003299 RID: 12953
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AdditionalDataLayers;
	}
}
